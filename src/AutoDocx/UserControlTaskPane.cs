using System;
using System.Linq;
using System.Windows.Forms;
using AutoDocx.Tools.DAL;
using AutoDocx.Tools;
using AutoDocx.Tools.Security;
using System.Diagnostics;
using System.Drawing;
using Word = Microsoft.Office.Interop.Word;
using AutoDocx.Tools;

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

            this.TaskPaneTabControl.SelectedIndexChanged += TaskPaneTabControl_SelectedIndexChanged;
            
            
            //this.HelpWebBrowser.
        }

        private void TaskPaneTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl ctr = sender as TabControl;
            if (ctr.SelectedTab == ctr.TabPages["Binding"])
            {
                
                LoadBindings();
            }
        }

        private void LoadBindings()
        {
            this.treeView1.Nodes.Clear();

            this.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treeView1.DrawNode += new DrawTreeNodeEventHandler(DrawNode);

            Methods _methods = new Methods();
            TemplateCustomXML tXML = _methods.ReadXML<TemplateCustomXML>(Globals.ThisAddIn.Application.ActiveDocument);
            Tools.Models.Template _temp = null;
            if (tXML != null)
            {
                _temp = _temp = ThisAddIn._document<Tools.Models.Template>(tXML.TemplateID);// 
                
                _temp.AutoDocuments.ForEach(au =>
                {
                    au = _unitOfWork.AutoDocumentRepository.FindBy(id => id.AutoDocumentID == au.AutoDocumentID, "BookMarkDatas");

                    TreeNode document = new TreeNode(au.Name);
                    document.Name = au.AutoDocumentID;


                    _temp.BookMarks.ForEach(bkmk =>
                    {
                        var bkd = au.BookMarkDatas.Where(aubd => aubd.BookMarkID == bkmk.BookMarkID).FirstOrDefault();
                        if (bkd == null)
                        {
                            var node = new TreeNode(bkmk.BookmarkName);
                            node.Tag = bkmk.BookmarkName;
                            node.Name = bkmk.BookMarkID;
                            node.ForeColor = System.Drawing.Color.Red;
                            document.Nodes.Add(node);

                            // document.ForeColor = System.Drawing.Color.Black;
                            document.ForeColor = System.Drawing.Color.Red;

                        }
                        else
                        {
                            var node = new TreeNode((bkmk.BookmarkName + " = " + bkd.BookMarkValue));
                            node.Tag = bkmk.BookmarkName;
                            node.Name = bkmk.BookMarkID;
                            document.Nodes.Add(node);

                        }


                    });

                    document.Checked = document.Nodes.Descendants().Where(n => n.ForeColor == System.Drawing.Color.Red).Any() ? false : true;
                    this.treeView1.Nodes.Add(document);
                    this.treeView1.CheckBoxes = true;

                });
            }
            
        }

        void DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                e.Node.HideCheckBox();
            }
            //e.Node.NodeFont = new System.Drawing.Font("Aerial", 10, FontStyle.Bold);
            //e.Node.Text = e.Node.Text;
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
            //if ((await Trial.CheckTrial()))
            //{
                //var selectednodes = treeView1.Nodes.Descendants().Where(n => n.Checked).Select(n => n.Text);
                var data = _unitOfWork.AutoDocumentRepository.GetAll().ToList();
                _extentions.CreateTemplatedDocuments(Globals.ThisAddIn.Application.ActiveDocument, data); 
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start(ThisAddIn.appRootDir + @"\Help\HELP.html");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                Word.Bookmark bk = Globals.ThisAddIn.Application.ActiveDocument.Bookmarks.get_Item(e.Node.Tag);
                object missing = Type.Missing;
                Globals.ThisAddIn.Application.ActiveWindow.ScrollIntoView(bk.Range, ref missing);

                Methods.GoToBookmark(e.Node.Name, e.Node.Parent.Name);
            }
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
