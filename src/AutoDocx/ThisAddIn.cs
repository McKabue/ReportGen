using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using AutoDocx.Tools;
using AutoDocx.Tools.Models;
using System;
using AutoDocx.Tools.DAL;
using System.IO;

namespace AutoDocx
{
    public partial class ThisAddIn
    {
        public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
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

        //public UnitOfWork 

        public Microsoft.Office.Tools.Word.Controls.CheckBox ToggleControl = new Microsoft.Office.Tools.Word.Controls.CheckBox();
        public Microsoft.Office.Tools.Word.Controls.CheckBox AutoDocSavePDF = new Microsoft.Office.Tools.Word.Controls.CheckBox();

        private static DatabaseContext _ctx = new DatabaseContext();
        public static DatabaseContext _databaseContext
        {
            get
            {
                return _ctx;
            }
            set
            {
                if ((_ctx == null))
                {
                    _ctx = value;
                }
                else
                {
                    throw new System.NotSupportedException();
                }
            }
        }

        private static UnitOfWork _uow = new UnitOfWork();
        public static UnitOfWork _unitOfWork
        {
            get
            {
                return _uow;
            }
            set
            {
                if ((_uow == null))
                {
                    _uow = value;
                }
                else
                {
                    throw new System.NotSupportedException();
                }
            }
        }


        public static T _document<T>(string ID)
        {
            if (typeof(T) == typeof(Template))
            {
                object _temp = _unitOfWork.TemplateRepository.FindBy(id => id.TemplateID == ID, "BookMarks, AutoDocuments");

                return (T)_temp;
            }


            return default(T);
        }



        public static Template SaveTemplate()
        {
            Methods _methods = new Methods();
            TemplateCustomXML tXML = _methods.ReadXML<TemplateCustomXML>(Globals.ThisAddIn.Application.ActiveDocument);
            Template _temp = null;
            if (tXML != null || (ThisAddIn._document<Template>(tXML.TemplateID) != null))
            {
                System.Windows.Forms.MessageBox.Show("Template Already Saved...");
                return null;
            } 



            ///////////////////////////////////////////////////
            

            SaveTemplateForm _saveTemplateForm = new SaveTemplateForm();

            if (_saveTemplateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!Globals.ThisAddIn.Application.ActiveDocument.Saved) Globals.ThisAddIn.Application.ActiveDocument.Save();

                //string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //string filename = _saveTemplateForm.TName.Text + ".docx";
                //else Document.SaveAs2(Path.Combine(documentsFolder, "Templates", filename));


                _saveTemplateForm.Dispose();
            }
            //_saveTemplateForm.dis.Show(new WindowInplementation(new IntPtr(Globals.ThisAddIn.Application.Windows[1].Hwnd)));
            _temp = new Template { TemplateID = Guid.NewGuid().ToString("D"), Name = _saveTemplateForm.TName.Text, Number = Convert.ToInt32(_saveTemplateForm.AutoDocs.Value), TemplatePath = Globals.ThisAddIn.Application.ActiveDocument.FullName };
            _unitOfWork.TemplateRepository.Add(_temp);
            _unitOfWork.Save();
            //else _unitOfWork.TemplateRepository.Add(new Template { TemplateID = Guid.NewGuid().ToString("D"), Name = _saveTemplateForm.TName.Text, Number = _saveTemplateForm.AutoDocs.Value, Path = Document.FullName });
            string xmlString = System.Text.Encoding.UTF8.GetString(_methods.GetTemplateXML(_temp.TemplateID).ToArray());
            Globals.ThisAddIn.Application.ActiveDocument.CustomXMLParts.Add(xmlString);


            return _temp;
        }












        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

            _unitOfWork.Seed();


            DisplayTaskPane();




            //this.Application.DocumentBeforeSave += new Word.ApplicationEvents4_DocumentBeforeSaveEventHandler(Application_DocumentBeforeSave);
            this.Application.DocumentChange += new Word.ApplicationEvents4_DocumentChangeEventHandler(documentChangeEvent);
            this.Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler(documentOpenEvent);
            //this.Application.WindowActivate += new Word.ApplicationEvents4_WindowActivateEventHandler(Application_WindowActivate);
            //this.Application.DocumentBeforeClose += new Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(DocumentBeforeClose);
        }



        private void documentOpenEvent(Word.Document Doc)
        {
            MyRibbon.ribbon.ActivateTab("CustomTab");

        }

        private void DisplayTaskPane()
        {
          


            _userControlTaskPane = new UserControlTaskPane();
            myCustomTaskPane = this.CustomTaskPanes.Add(_userControlTaskPane, "AutoDocx");
            //myCustomTaskPane.VisibleChanged += new EventHandler(myCustomTaskPane_VisibleChanged);
            myCustomTaskPane.Width = 500;
            //msoCTPDockPositionLeft = 0, msoCTPDockPositionTop = 1, msoCTPDockPositionRight = 2, msoCTPDockPositionBottom = 3,  soCTPDockPositionFloating = 4
            //myCustomTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionFloating;
            myCustomTaskPane.Visible = true;



            
        }


        public void documentChangeEvent()
        {
                var vstoDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
                vstoDocument.SelectionChange += new Microsoft.Office.Tools.Word.SelectionEventHandler(UserControlTaskPane.ThisDocument_SelectionChange); 
         
            
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
            //return Globals.Factory.GetRibbonFactory().CreateRibbonManager(new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { new MyRibbon() });
            return new MyRibbon();
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
