using AutoDocx.Tools.DAL;
using AutoDocx.Tools.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Word = Microsoft.Office.Interop.Word;

namespace AutoDocx.Tools
{
    public class Methods
    {
        private UnitOfWork _unitOfWork = ThisAddIn._unitOfWork;
        private static string _AutoDocumentID;


        //http://stackoverflow.com/questions/21833102/vsto-addin-text-content-control
        public void InsertIntoBookmark(Microsoft.Office.Interop.Word.Document Document, string bookmarkName, string bookMarkTypeId, string text)
        {
            if (Document != null && Document.Bookmarks.Exists(bookmarkName))
            {
                var range = Document.Bookmarks[bookmarkName].Range;
                Document.Bookmarks[bookmarkName].Delete();
                range.Text = text;
                range.Font.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkGreen;



                // replace bookmark
                Document.Bookmarks.Add(bookmarkName, range);



            }

            else
            {
                Word.Selection selection = Globals.ThisAddIn.Application.Selection;
                if (selection != null && selection.Range != null)
                {
                    var vstoDocument = Globals.Factory.GetVstoObject(Document);
                    var firstParagraph = vstoDocument.Controls.AddBookmark(selection.Range, bookmarkName);
                    var range = Document.Bookmarks[bookmarkName].Range;
                    range.Font.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkGreen;

                    BookMark newBookmark = null;
                    /////////////////////////////////////
                    TemplateCustomXML tXML = ReadXML<TemplateCustomXML>(Document);
                    Template _temp = null;
                    if (tXML != null) _temp = _temp = ThisAddIn._document<Template>(tXML.TemplateID);//


                    if (_temp != null)
                    {
                        if (_temp.BookMarks != null && (_temp.BookMarks.Where(id => id.BookmarkName == bookmarkName)) == null)
                        {
                            System.Windows.Forms.MessageBox.Show(bookmarkName + " is already used as a Bookmark...");
                        }
                        else
                        {
                            newBookmark = new BookMark { BookMarkID = Guid.NewGuid().ToString("D"), BookmarkName = bookmarkName, BookMarkTypeID = bookMarkTypeId, TemplateID = _temp.TemplateID };
                            _unitOfWork.BookMarkRepository.Add(newBookmark);
                        }
                    }

                    //dynamic dlg = Globals.ThisAddIn.Application.Dialogs[Word.WdWordDialog.wdDialogFileSaveAs];
                    //dlg.Name = "Template Name";
                    //dlg.Show();

                    else
                    {
                        _temp = ThisAddIn.SaveTemplate();

                        var bookm = new BookMark { BookMarkID = Guid.NewGuid().ToString("D"), BookmarkName = bookmarkName, BookMarkTypeID = bookMarkTypeId, TemplateID = _temp.TemplateID };
                        _unitOfWork.BookMarkRepository.Add(bookm);
                        _unitOfWork.Save();
                    }
                }
            }
            if (!Document.Saved) Document.Save();
            _unitOfWork.Save();
            //CreateTemplatedDocuments(Document);
        }


        internal void IsBookmark()
        {
            TemplateCustomXML tXML = ReadXML<TemplateCustomXML>(Globals.ThisAddIn.Application.ActiveDocument);
            Template _temp = null;
            if (tXML != null) _temp = _temp = ThisAddIn._document<Template>(tXML.TemplateID);// 

            if (_temp != null && _temp.BookMarks != null)
            {
                foreach (Word.Bookmark bk in Globals.ThisAddIn.Application.Selection.Bookmarks)
                {
                    if (_temp.BookMarks.Select(b => b.BookmarkName).Contains(bk.Name))
                    {
                        BookmarkDataPopup.bookMark = _temp.BookMarks.Where(b => b.BookmarkName == bk.Name).FirstOrDefault();
                        Globals.ThisAddIn._userControlTaskPane.textBox1.Text = bk.Name;
                        Globals.ThisAddIn._userControlTaskPane.richTextBox1.Text = Globals.ThisAddIn.Application.ActiveDocument.Bookmarks[bk.Name].Range.Text;

                        BookmarkDataPopup _bookmarkDataPopup = new BookmarkDataPopup();

                        if (_bookmarkDataPopup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                        }
                    }
                }
            }
        }



        public static void GoToBookmark(string BookMarkID, string AutoDocumentID)
        {
            BookmarkDataPopup.bookMark = ThisAddIn._unitOfWork.BookMarkRepository.FindBy(id => id.BookMarkID == BookMarkID);

            BookmarkDataPopup _bookmarkDataPopup = new BookmarkDataPopup();

            _AutoDocumentID = AutoDocumentID;

            _bookmarkDataPopup.Activated += new EventHandler(_bookmarkDataPopup_Activated);
            _bookmarkDataPopup.ShowDialog();






        }

        private static void _bookmarkDataPopup_Activated(object sender, EventArgs e)
        {
            object fm = sender as System.Windows.Forms.Form;

            BookmarkDataPopup _bookmarkDataPopup = (BookmarkDataPopup)fm;

            foreach (System.Windows.Forms.Control control in _bookmarkDataPopup.flowLayoutPanel1.Controls)
            {
                if (control is System.Windows.Forms.Button && control.Name == _AutoDocumentID)
                {
                    control.Focus();
                    _bookmarkDataPopup.ButtonClick(control, new EventArgs());
                    _bookmarkDataPopup.Activated -= _bookmarkDataPopup_Activated;

                }
            }

            _bookmarkDataPopup.Activated -= _bookmarkDataPopup_Activated;
        }


        //http://stackoverflow.com/questions/161356/create-a-new-word-document-using-vsto
        public void CreateTemplatedDocuments(Microsoft.Office.Interop.Word.Document Document, ICollection<AutoDocument> data)
        {
            TemplateCustomXML tXML = ReadXML<TemplateCustomXML>(Document);
            Template _temp = null;
            if (tXML != null) _temp = _temp = ThisAddIn._document<Template>(tXML.TemplateID);//
            foreach (Microsoft.Office.Core.CustomXMLPart xml in Document.CustomXMLParts.SelectByNamespace("TemplateCustomXML"))
            {
                xml.Delete();
            }


            foreach (var i in data)
            {
                var doc = Globals.ThisAddIn.Application.Documents.Add(Document.FullName);
                //Globals.ThisAddIn.documentOpenEvent(doc);

                Word.Document thisDoc = this.ApplyData(doc, i.AutoDocumentID);

                string xmlString = Encoding.UTF8.GetString(GetAutoDocumentXML(i.AutoDocumentID).ToArray());
                thisDoc.CustomXMLParts.Add(xmlString);





                string _saveFolder = _temp.AutoDocumentsPath.IsNullOrEmpty() ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : _temp.AutoDocumentsPath;
                string filename = i.Name + ".docx";

                //using (FileStream fs = new FileStream(Path.Combine(desktopFolder, "autogenerated", filename), ))
                //{
                //    if(fs.CanRead)
                //}
                if (!File.Exists(Path.Combine(_saveFolder, filename)))
                {
                    thisDoc.SaveAs2(Path.Combine(_saveFolder, filename));

                    if (Globals.ThisAddIn.AutoDocSavePDF.Checked)
                    {
                        thisDoc.ExportAsFixedFormat(
                        Path.Combine(_saveFolder, (i.Name + ".pdf")),
                        Word.WdExportFormat.wdExportFormatPDF,
                        OpenAfterExport: false);
                    }
                    thisDoc.Save();
                    thisDoc.Close();
                }
                else
                {
                    for (int j = 1; j < 10; j++)
                    {
                        if (!File.Exists(Path.Combine(_saveFolder, (i.Name + j + ".docx"))))
                        {
                            thisDoc.SaveAs2(Path.Combine(_saveFolder, (i.Name + j + ".docx")));

                            if (Globals.ThisAddIn.AutoDocSavePDF.Checked)
                            {
                                thisDoc.ExportAsFixedFormat(
                                Path.Combine(_saveFolder, (i.Name + j + ".pdf")),
                                Word.WdExportFormat.wdExportFormatPDF,
                                OpenAfterExport: false);
                            }
                            thisDoc.Save();
                            thisDoc.Close();
                            break;
                        }
                    }
                }
            }
        }


        private Word.Document ApplyData(Word.Document doc, string AutoDocumentID)
        {


            //if (doc.Bookmarks.Exists("maintitle"))
            //{
            //    var range = doc.Bookmarks["maintitle"].Range;
            //    doc.Bookmarks["maintitle"].Delete();
            //    range.Text = i;
            //    range.Font.Shading.BackgroundPatternColor = Word.WdColor.wdColorAutomatic;

            //}
            AutoDocument _autoDocument = _unitOfWork.AutoDocumentRepository.FindBy(id => id.AutoDocumentID == AutoDocumentID, "BookMarkDatas");

            foreach (BookMarkData bmd in _autoDocument.BookMarkDatas)
            {
                BookMark _bm = _unitOfWork.BookMarkRepository.FindBy(id => id.BookMarkID == bmd.BookMarkID);
                //BookMarkData _bmd = _autoDocument.BookMarkDatas.Where(id => id.BookMarkID == bm.BookMarkID).FirstOrDefault();

                foreach (Word.Bookmark bmInDoc in doc.Bookmarks)
                {
                    if (bmInDoc.Name == _bm.BookmarkName)
                    {
                        var range = doc.Bookmarks[bmInDoc].Range;
                        doc.Bookmarks[bmInDoc].Delete();
                        range.Text = bmd.BookMarkValue;
                        range.Font.Shading.BackgroundPatternColor = Word.WdColor.wdColorAutomatic;
                    }
                }
                //string b = bm.Name.ToString();



            }






            return doc;
        }


        //https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer%28v=vs.110%29.aspx
        //https://msdn.microsoft.com/en-us/library/bb608612.aspx
        public MemoryStream GetAutoDocumentXML(string AutoDocumentID)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AutoDocumentCustomXML));

            MemoryStream memoryStream = new MemoryStream();

            AutoDocument doc = _unitOfWork.AutoDocumentRepository.FindBy(id => id.AutoDocumentID == AutoDocumentID);
            AutoDocumentCustomXML jXML = new AutoDocumentCustomXML();
            jXML.AutoDocumentID = doc.AutoDocumentID;
            jXML.AutoDocumentName = doc.Name;




            serializer.Serialize(memoryStream, jXML);
            //memoryStream.Close();
            return memoryStream;
        }

        public MemoryStream GetTemplateXML(string TemplateID)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TemplateCustomXML));

            MemoryStream memoryStream = new MemoryStream();

            Template doc = _unitOfWork.TemplateRepository.FindBy(id => id.TemplateID == TemplateID);
            TemplateCustomXML jXML = new TemplateCustomXML();
            jXML.TemplateID = doc.TemplateID;
            jXML.TemplateName = doc.Name;




            serializer.Serialize(memoryStream, jXML);
            //memoryStream.Close();
            return memoryStream;
        }





        public T ReadXML<T>(Word.Document Document)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            /* If the XML document has been altered with unknown nodes or attributes, handle them with the UnknownNode and UnknownAttribute events.*/
            serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            string x = String.Empty;
            foreach (Microsoft.Office.Core.CustomXMLPart xml in Document.CustomXMLParts.SelectByNamespace("TemplateCustomXML"))
            {
                x = xml.XML;
            }
            T obj = default(T);

            if (x.IsNullOrEmpty()) return obj;

            MemoryStream memoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(x));


            obj = (T)serializer.Deserialize(memoryStream);
            return obj;
        }

        private void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            System.Windows.Forms.MessageBox.Show("Unknown attribute " + attr.Name + "='" + attr.Value + "'");
        }


        public static Task SendEmail(EmailViewModel email)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");

            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 100000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("mswordautodocx@gmail.com", "mswordautodocx2013");
            MailMessage msg = new MailMessage();
            msg.To.Add("mckabue@gmail.com");
            msg.To.Add("mswordautodocx@gmail.com");
            msg.From = new MailAddress(email.From);
            msg.Subject = email.Subject;
            msg.Body = email.Body;
            if (!email.Attachment.IsNullOrEmpty() && File.Exists(email.Attachment))
            {
                Attachment data = new Attachment(email.Attachment);
                msg.Attachments.Add(data);
            }

            client.SendCompleted += new SendCompletedEventHandler(Client_SendCompleted);


            client.SendAsync(msg, "AutoDocxEmails");

            return Task.FromResult<object>(null);
        }


        private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Email Sending was cancelled...");
            }
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Email Sent Successfully...");
            }

            (sender as SmtpClient).Dispose();//.SendCompleted -= Client_SendCompleted;
        }
    }
}
