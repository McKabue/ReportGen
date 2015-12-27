using AutoDocx.Tools;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace AutoDocx
{
    public partial class MyRibbon
    {
        //Create callback methods here. For more information about adding callback methods, visit http://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            ribbon = ribbonUI;

        }

        public void ShowTaskpane(Office.IRibbonControl control, bool pressed)
        {
            Globals.ThisAddIn.TaskPane.Visible = pressed;



        }

        public bool checkedcheckbox(Office.IRibbonControl control)
        {
            return true;
        }

        public void AutoDocSavePDF(Office.IRibbonControl control, bool pressed)
        {
            Globals.ThisAddIn.AutoDocSavePDF.Checked = pressed;
        }

        public void AutoDocSaveFolder(Office.IRibbonControl control)
        {

            //System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog();
            //save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //save.RestoreDirectory = true;

            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //System.Windows.Forms.MessageBox.Show(fbd.SelectedPath);
                Methods _methods = new Methods();
                TemplateCustomXML tXML = _methods.ReadXML<TemplateCustomXML>(Globals.ThisAddIn.Application.ActiveDocument);
                Tools.Models.Template _temp = null;
                if (tXML != null) _temp = _temp = ThisAddIn._document<Tools.Models.Template>(tXML.TemplateID);//

                _temp.AutoDocumentsPath = fbd.SelectedPath;
                ThisAddIn._unitOfWork.Save();
            }


        }

        public void SaveTemplate(Office.IRibbonControl control)
        {
            Tools.Models.Template _temp = ThisAddIn.SaveTemplate();
        }

        public void Author(Office.IRibbonControl control)
        {
            Process.Start("http://twitter.com/mckabue");
        }
    }
}
