using ReportGen.Tools.DAL;
using ReportGen.Tools.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Word = Microsoft.Office.Interop.Word;

namespace ReportGen.Tools
{
    public class Methods
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();


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
                    Microsoft.Office.Core.CustomXMLParts xml = Document.CustomXMLParts.SelectByNamespace("TemplateCustomXML");
                    /////////////////////////////////////
                    Template _temp = _unitOfWork.TemplateRepository.FindBy(id => id.Path == Document.FullName);
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
                        SaveTemplateForm _saveTemplateForm = new SaveTemplateForm();

                        if (_saveTemplateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (!Document.Saved) Document.Save();

                            //string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            //string filename = _saveTemplateForm.TName.Text + ".docx";
                            //else Document.SaveAs2(Path.Combine(documentsFolder, "Templates", filename));


                            _saveTemplateForm.Dispose();
                        }
                        //_saveTemplateForm.dis.Show(new WindowInplementation(new IntPtr(Globals.ThisAddIn.Application.Windows[1].Hwnd)));
                        _temp = new Template { TemplateID = Guid.NewGuid().ToString("D"), Name = _saveTemplateForm.TName.Text, Number = Convert.ToInt32(_saveTemplateForm.AutoDocs.Value), BookMarks = new List<BookMark> { new BookMark { BookMarkID = Guid.NewGuid().ToString("D"), BookmarkName = bookmarkName, BookMarkTypeID = bookMarkTypeId } }, Path = Document.FullName };
                        _unitOfWork.TemplateRepository.Add(_temp);
                        //else _unitOfWork.TemplateRepository.Add(new Template { TemplateID = Guid.NewGuid().ToString("D"), Name = _saveTemplateForm.TName.Text, Number = _saveTemplateForm.AutoDocs.Value, Path = Document.FullName });
                        string xmlString = Encoding.UTF8.GetString(GetTemplateXML(_temp.TemplateID).ToArray());
                        Document.CustomXMLParts.Add(xmlString);
                    }
                } 
            }
            if (!Document.Saved) Document.Save();
            _unitOfWork.Save();
            //CreateTemplatedDocuments(Document);
        }


        internal void IsBookmark()
        {
            string path = Globals.ThisAddIn.Application.ActiveDocument.FullName;
            Template _temp = _unitOfWork.TemplateRepository.FindBy(id => id.Path == path, "BookMarks");

            if (_temp != null && _temp.BookMarks != null)
            {
                foreach (Word.Bookmark bk in Globals.ThisAddIn.Application.Selection.Bookmarks)
                {
                    if (_temp.BookMarks.Select(b => b.BookmarkName).Contains(bk.Name))
                    {
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


        //http://stackoverflow.com/questions/161356/create-a-new-word-document-using-vsto
        public void CreateTemplatedDocuments(Microsoft.Office.Interop.Word.Document Document, ICollection<AutoDocument> data)
        {
            //var temp = Globals.ThisAddIn.Application.Templates;

            foreach (var i in data)
            {
                var doc = Globals.ThisAddIn.Application.Documents.Add(Document.FullName);
                //Globals.ThisAddIn.documentOpenEvent(doc);

                Word.Document thisDoc = this.ApplyData(doc, i.AutoDocumentID);

                string xmlString = Encoding.UTF8.GetString(GetAutoDocumentXML(i.AutoDocumentID).ToArray());
                thisDoc.CustomXMLParts.Add(xmlString);





                string _myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filename = i.Name + ".docx";

                //using (FileStream fs = new FileStream(Path.Combine(desktopFolder, "autogenerated", filename), ))
                //{
                //    if(fs.CanRead)
                //}
                if(!File.Exists(Path.Combine(_myDocumentsFolder, filename)))
                {
                    thisDoc.SaveAs2(Path.Combine(_myDocumentsFolder, filename));

                    if (Globals.ThisAddIn.AutoDocSavePDF.Checked)
                    {
                        thisDoc.ExportAsFixedFormat(
                        Path.Combine(_myDocumentsFolder, (i.Name + ".pdf")),
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
                        if (!File.Exists(Path.Combine(_myDocumentsFolder, (i.Name + j + ".docx"))))
                        {
                            thisDoc.SaveAs2(Path.Combine(_myDocumentsFolder, (i.Name + j + ".docx")));

                            if (Globals.ThisAddIn.AutoDocSavePDF.Checked)
                            {
                                thisDoc.ExportAsFixedFormat(
                                Path.Combine(_myDocumentsFolder, (i.Name + j + ".pdf")),
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
                    if(bmInDoc.Name == _bm.BookmarkName)
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

            /* If the XML document has been altered with unknown nodes or attributes, handle them with the UnknownNode and UnknownAttribute events.*/
            serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

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

            /* If the XML document has been altered with unknown nodes or attributes, handle them with the UnknownNode and UnknownAttribute events.*/
            serializer.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);

            MemoryStream memoryStream = new MemoryStream();

            Template doc = _unitOfWork.TemplateRepository.FindBy(id => id.TemplateID == TemplateID);
            TemplateCustomXML jXML = new TemplateCustomXML();
            jXML.TemplateID = "doc.TemplateID";
            jXML.TemplateName = "doc.Name";




            serializer.Serialize(memoryStream, jXML);
            //memoryStream.Close();
            return memoryStream;
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
    }
}
