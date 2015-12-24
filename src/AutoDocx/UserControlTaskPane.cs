using System;
using System.Linq;
using System.Windows.Forms;
using AutoDocx.Tools.DAL;
using AutoDocx.Tools;
using AutoDocx.Tools.Security;
using System.Diagnostics;

namespace AutoDocx
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
            //this.bookMarkTypeComboBox.disabled
            string link = ThisAddIn.appRootDir + @"\Help\HELP.html";
            //this.HelpWebBrowser.Url = new System.Uri(link, System.UriKind.Absolute);


            LoadBindings();
            
            //this.HelpWebBrowser.
        }

        private void LoadBindings()
        {
            this.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treeView1.DrawNode += new DrawTreeNodeEventHandler(DrawNode);

            _unitOfWork.AutoDocumentRepository.GetAll().ForEach(au =>
            {
                au = _unitOfWork.AutoDocumentRepository.FindBy(id => id.AutoDocumentID == au.AutoDocumentID, "BookMarkDatas");

                TreeNode document = new TreeNode(au.Name);
                

                _unitOfWork.BookMarkRepository.GetAll().ForEach(bkmk =>
                {
                    var bkd = au.BookMarkDatas.Where(aubd => aubd.BookMarkID == bkmk.BookMarkID).FirstOrDefault();
                    if (bkd == null)
                    {
                        var node = new TreeNode(bkmk.BookmarkName);
                        node.ForeColor = System.Drawing.Color.Red;
                        document.Nodes.Add(node);

                        // document.ForeColor = System.Drawing.Color.Black;
                        document.ForeColor = System.Drawing.Color.Red;
                        document.Checked = true;
                    }
                    else
                    {
                        document.Nodes.Add(new TreeNode((bkmk.BookmarkName + " = " + bkd.BookMarkValue)));
                    }

                });
                this.treeView1.Nodes.Add(document);
                this.treeView1.CheckBoxes = true;
            });
        }

        void DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                e.Node.HideCheckBox(); 
                //e.Node.NodeFont = 
            }
            e.DrawDefault = true;
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
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBox1.Text.Trim(), @"^([a-zA-Z]|[a-zA-Z]+[a-zA-Z0-9])*$"))
            {
                
                // _extentions.InsertIntoBookmark(Globals.ThisAddIn.Application.ActiveDocument, this.textBox1.Text, (string)this.bookMarkTypeComboBox.SelectedValue, this.richTextBox1.Text);
                _extentions.InsertIntoBookmark(Globals.ThisAddIn.Application.ActiveDocument, this.textBox1.Text, "1", this.richTextBox1.Text); 
            }
            else
            {
                MessageBox.Show("Bad name");
            }
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
            if ((Trial.CheckTrial()))
            {
                var data = _unitOfWork.AutoDocumentRepository.GetAll().ToList();
                _extentions.CreateTemplatedDocuments(Globals.ThisAddIn.Application.ActiveDocument, data); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(ThisAddIn.appRootDir + @"\Help\HELP.html");
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
