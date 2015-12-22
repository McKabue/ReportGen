using Microsoft.Office.Tools.Word;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ReportGen
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private const int DISP_E_BADINDEX = unchecked((int)0x8002000B);
        //private FormEvents _formEvents = new FormEvents();

        private void ControlForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "MyRichTextBoxControl";
            Document vstoDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);

            //var richTextControlTag = vstoDocument.SelectContentControlsByTag("richTextControlTag");

            //GetEnumerator(Globals.ThisAddIn.Application.ActiveDocument.ContentControls);
            var doc = Globals.ThisAddIn.Application.ActiveDocument;

            if (true)
            {
               // Extentions.InsertIntoBookmark(Globals.ThisAddIn.Application.ActiveDocument, "bookmarkName", "this.richTextBox1.Text");
            }
            else
            {
                Word.ContentControl richTextBox = null;

                try
                {
                    richTextBox = vstoDocument.ContentControls.get_Item(name);
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    // "MyListObject" does not exist.
                    if (ex.ErrorCode != DISP_E_BADINDEX)
                        throw;
                }
            }
            

            
        }

        

        //public static string GetContentControlValueByTag(string location, string tag)
        //{
        //    // Open the Word document specified by "location".
        //    using (WordprocessingDocument theDoc = WordprocessingDocument.Open(location, true))
        //    {
        //        // Get the package part that holds the main document content.
        //        MainDocumentPart mainPart = theDoc.MainDocumentPart;

        //        // Find the content content control whose Tag value == tag.
        //        // In this case, the tag value is "idPolicyNumber".
        //        SdtRun policyNumberCC = mainPart.Document.Body.Descendants<SdtRun>().Where(r => r.SdtProperties.GetFirstChild<Tag>().Val == tag).SingleOrDefault();

        //        // Find the <sdtContent> element of the content control.
        //        SdtContentRun contentRun = policyNumberCC.GetFirstChild<SdtContentRun>();

        //        // Get the string inside the content control.
        //        string policyNumber = contentRun.GetFirstChild<Run>().GetFirstChild<Text>().InnerText;

        //        return policyNumber;
        //    }
        //}

        public IEnumerator<Word.ContentControls> GetEnumerator(Word.ContentControls contentControls)
        {
            System.Collections.IEnumerator en = contentControls.GetEnumerator();
            var ob = new List<object>();
            while (en.MoveNext())
            {
                // VSTO Document.Controls includes all managed controls, not just 
                // VSTO ContentControls; return only those.
                if (en.Current is Microsoft.Office.Tools.Word.ContentControl)
                {
                    // The control's name isn't stored with the control, only when it was added,
                    // so use a placeholder name for the wrapper.
                    ob.Add(en.Current);
                    //yield return new ContentControl("Unknown", (Microsoft.Office.Tools.Word.ContentControl)en.Current);
                }
            }

            return ob as IEnumerator<Word.ContentControls>;
        }

        



        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (this.richTextBox1.Text == "")
        //    {
        //        this.richTextBox1.Text = Globals.ThisAddIn.Application.Selection.Range.XML;
        //    }
        //    else
        //    {
        //        Globals.ThisAddIn.Application.ActiveDocument.Paragraphs[1].Range.InsertParagraphBefore();
        //        //Globals.ThisAddIn.Application.ActiveDocument.Paragraphs[1].Range.Text = this.richTextBox1.Text;
        //        Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.InsertXML(this.richTextBox1.Text);

        //    }
        //}
    }
}
