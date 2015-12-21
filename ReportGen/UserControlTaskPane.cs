using System;
using System.Linq;
using System.Windows.Forms;
using ReportGen.Tools.DAL;
using ReportGen.Tools;

namespace ReportGen
{
    public partial class UserControlTaskPane : UserControl
    {
        private Methods _extentions = new Methods();
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public UserControlTaskPane()
        {
            InitializeComponent();
            

            this.bookMarkTypeComboBox.DataSource = _unitOfWork.BookMarkTypeRepository.GetAll();
            this.bookMarkTypeComboBox.DisplayMember = "BookMarkTypeString";
            this.bookMarkTypeComboBox.ValueMember = "BookMarkTypeID";
        }
        
        private void MakeVariable_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Make Variable?", "hhh", MessageBoxButtons.YesNoCancel);
            //Globals.ThisAddIn.ToggleRichTextControlOnDocument();
            ////this.EditableVariables.

            ControlForm form = new ControlForm();
            form.Show();
        }

        private void SaveBookmark_Click(object sender, EventArgs e)
        {
            _extentions.InsertIntoBookmark(Globals.ThisAddIn.Application.ActiveDocument, this.textBox1.Text, (string)this.bookMarkTypeComboBox.SelectedValue, this.richTextBox1.Text);
           
        }



        //https://msdn.microsoft.com/en-us/library/microsoft.office.tools.word.document.selectionchange.aspx
        public static void ThisDocument_SelectionChange(object sender, Microsoft.Office.Tools.Word.SelectionEventArgs e)
        {
           Globals.ThisAddIn._userControlTaskPane.richTextBox1.Text = e.Selection.Text;

            Methods _methods = new Methods();
            _methods.IsBookmark();
        }

        private void AutoGenerate_Click(object sender, EventArgs e)
        {
            var data = _unitOfWork.AutoDocumentRepository.GetAll().ToList();
            _extentions.CreateTemplatedDocuments(Globals.ThisAddIn.Application.ActiveDocument, data);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Word.Dialog dlg = Globals.ThisAddIn.Application.Dialogs[Word.WdWordDialog.wdDialogInsertPicture];
        //    // //dlg.Application.
        //    // dlg.Show();

        //    ControlForm form = new ControlForm();
        //    form.Show(new WindowInplementation(new IntPtr(Globals.ThisAddIn.Application.Windows[1].Hwnd)));
        //}

        




        //private void makeEditable_Click(object sender, EventArgs e)
        //{
        //    this.richTextBox1.Text = Globals.ThisAddIn.Application.Selection.Text;
        //    Globals.ThisAddIn.Application.Selection.Range.Text = (Globals.ThisAddIn.Application.Selection.XML);
        //}
    }
}
