using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using ReportGen.Tools;

namespace ReportGen
{
    public partial class ThisAddIn
    {
        public UserControlTaskPane _userControlTaskPane;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return myCustomTaskPane;
            }
        }
        private Methods _methods = new Methods();

        public Microsoft.Office.Tools.Word.Controls.CheckBox ToggleControl = new Microsoft.Office.Tools.Word.Controls.CheckBox();




        




        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //var _context = new DatabaseContext();
            //var MySqlInitializer = new MySqlInitializer();
            //MySqlInitializer.InitializeDatabase(_context);
            //var _context = new DatabaseContext();
            //var SQLITEInitializer = new SQLITEInitializer();
            //SQLITEInitializer.InitializeDatabase(_context);


            _userControlTaskPane = new UserControlTaskPane();
            myCustomTaskPane = this.CustomTaskPanes.Add(_userControlTaskPane, "ReportGen");
            //myCustomTaskPane.VisibleChanged += new EventHandler(myCustomTaskPane_VisibleChanged);
            myCustomTaskPane.Width = 500;
            //msoCTPDockPositionLeft = 0, msoCTPDockPositionTop = 1, msoCTPDockPositionRight = 2, msoCTPDockPositionBottom = 3,  soCTPDockPositionFloating = 4
            //myCustomTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionFloating;
            myCustomTaskPane.Visible = true; // TaskPane.Visible;

            //this.Application.DocumentBeforeSave += new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(Application_DocumentBeforeSave);
            this.Application.DocumentChange += new Word.ApplicationEvents4_DocumentChangeEventHandler(documentChangeEvent);
            //this.Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler(documentOpenEvent);
        }

        

        //public void documentOpenEvent(Word.Document doc)
        //{
        //    doc.Paragraphs[1].Range.InsertParagraphBefore();
        //    doc.Paragraphs[1].Range.Text = "This text was added by using code.";
        //}

        public void documentChangeEvent()
        {
            
            var vstoDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
            vstoDocument.SelectionChange += new Microsoft.Office.Tools.Word.SelectionEventHandler(UserControlTaskPane.ThisDocument_SelectionChange);

            //foreach (Word.Bookmark bk in Globals.ThisAddIn.Application.Selection.Bookmarks)
            //{
            //    vstoDocument.Bookmarks[bk].Delete();
            //}
        }


        
        //void documentChangeEvent()
        //{
        //    this.Application.ActiveDocument.ContentControlOnEnter += new Word.DocumentEvents2_ContentControlOnEnterEventHandler(ShowTaskPane);
        //    this.Application.ActiveDocument.ContentControlOnExit += new Word.DocumentEvents2_ContentControlOnExitEventHandler(HideTaskPane);

        //}



        //void Application_WindowActivate(Word.Document document, Word.Window wnd)
        //{ 

        //}



        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        //void Application_DocumentBeforeSave(Word.Document Doc, ref bool SaveAsUI, ref bool Cancel)
        //{
        //    Doc.Paragraphs[1].Range.InsertParagraphBefore();
        //    Doc.Paragraphs[1].Range.Text = "This text was added by using code.";
        //}

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new MyRibbon();
        }

        //public static string GetContentControlValueByTag(string location, string tag)
        //{
        //    // Open the Word document specified by "location".
        //    using (Word.ope theDoc = WordprocessingDocument.Open(location, true))
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

        internal void ToggleRichTextControlOnDocument()
        {
            
            Document vstoDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);
            Document extendedDocument = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);


            string name = "MyRichTextBoxControl";

            if (ToggleControl.Checked)
            {
                Word.Selection selection = this.Application.Selection;
                if (selection != null && selection.Range != null)
                {
                    //richTextControl = vstoDocument.Controls.AddRichTextContentControl(selection.Range, name);
                    //richTextControl.Tag = "richTextControlTag";
                    Bookmark firstParagraph = extendedDocument.Controls.AddBookmark(selection.Range, "bookmarkName");
                    
                }
            }
            else
            {
                vstoDocument.Controls.Remove(name);
            }
        }



        void ShowTaskPane(Microsoft.Office.Interop.Word.ContentControl ContentControl)

        {
            foreach (Microsoft.Office.Tools.CustomTaskPane taskPane in this.CustomTaskPanes)

            {
                
                if ((taskPane != null) && (taskPane.Control is UserControlTaskPane))

                {
                    taskPane.Visible = true;

                }

            }

        }

        void HideTaskPane(Microsoft.Office.Interop.Word.ContentControl ContentControl, ref bool Cancel)

        {

            foreach (Microsoft.Office.Tools.CustomTaskPane taskPane in this.CustomTaskPanes)

            {

                if ((taskPane != null) && (taskPane.Control is UserControlTaskPane))

                {

                    taskPane.Visible = false;

                }

            }

        }






        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
