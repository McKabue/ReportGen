using AutoDocx.Tools.DAL;
using System;
using System.Linq;
using System.Windows.Forms;
using AutoDocx.Tools;
using AutoDocx.Tools.Models;

namespace AutoDocx
{
    public partial class BookmarkDataPopup : Form
    {
        public BookmarkDataPopup()
        {
            InitializeComponent();
        }
        private UnitOfWork _unitOfWork = ThisAddIn._unitOfWork;
        private Methods _methods = new Methods();
        public static Button senderButton;
        public static RichTextBox richtxb = new RichTextBox();
        public static Button ptBtn = new Button();
        public static BookMark bookMark = new BookMark();
        Button _autoDocSaveClick;



        private void BookmarkDataPopup_Load(object sender, EventArgs e)
        {
            //var tabname = Globals.ThisAddIn._userControlTaskPane.textBox1.Text;

            //this.DataTypeTabControl.SelectedTab = this.DataTypeTabControl.TabPages["DateTime"];
            
            LoadDocumentButtons();
        }

        private void LoadDocumentButtons()
        {
            
            Methods _methods = new Methods();
            TemplateCustomXML tXML = _methods.ReadXML<TemplateCustomXML>(Globals.ThisAddIn.Application.ActiveDocument);
            Template _temp = null;
            if (tXML != null) _temp = _temp = ThisAddIn._document<Template>(tXML.TemplateID);//


            foreach (AutoDocument autoD in _temp.AutoDocuments)
            {
                Button lb1 = new Button();
                lb1.Text = autoD.Name;
                lb1.AutoSize = true;
                lb1.Name = autoD.AutoDocumentID;
                lb1.Click += new EventHandler(ButtonClick);
                flowLayoutPanel1.Controls.Add(lb1);
            }

            for (int i = 1; i <= (_temp.Number - _temp.AutoDocuments.Count()); i++)
            {
                Button lb1 = new Button();
                lb1.Text = "Unnamed Document " + i;
                lb1.AutoSize = true;
                lb1.Name = "";
                lb1.Click += new EventHandler(ButtonClick);
                flowLayoutPanel1.Controls.Add(lb1);
            }
        }
        public void ButtonClick(object sender, EventArgs e)
        {
            senderButton = sender as Button;

            //var tabname = Globals.ThisAddIn._userControlTaskPane.textBox1.Text;
            //this.DataTypeTabControl.SelectedTab = this.DataTypeTabControl.TabPages[tabname];

            if (senderButton.Name.IsNullOrEmpty())
            {
                NewAutoDocument _newAutoDocument = new NewAutoDocument();

                if (_newAutoDocument.ShowDialog() == DialogResult.OK)
                {
                    TemplateCustomXML tXML = _methods.ReadXML<TemplateCustomXML>(Globals.ThisAddIn.Application.ActiveDocument);
                    Template _temp = null;
                    if (tXML != null) _temp = _temp = ThisAddIn._document<Template>(tXML.TemplateID);//



                    var autd = new AutoDocument { AutoDocumentID = Guid.NewGuid().ToString("D"), Name = _newAutoDocument.AutoDocumentName.Text, TemplateID = _temp.TemplateID };
                    _unitOfWork.AutoDocumentRepository.Add(autd);
                    _unitOfWork.Save();
                    senderButton.Text = autd.Name;
                    senderButton.Name = autd.AutoDocumentID;
                    _newAutoDocument.Dispose();
                }
            }
            else
            {
                if (this.DataTypeTabControl.SelectedTab.Text == this.PlainText.Text)
                {
                    PlainTextControlLoader();
                }
            }


        }
        private void PlainTextControlLoader()
        {
            BookMarkData previousBookMarkData = _unitOfWork.BookMarkDataRepository.FindBy(id => id.BookMarkID == bookMark.BookMarkID && id.AutoDocumentID == senderButton.Name);
            //richtxb.Dock = DockStyle.Top;
            //richtxb.Size = new Size(2000, 50);
            richtxb.Width = (flowLayoutPanel2.Width - 8);
            richtxb.Name = "AutoDocValue";
            richtxb.Text = (previousBookMarkData == null ? "" : previousBookMarkData.BookMarkValue); //"previous input...";




            ptBtn.Name = "AutoDocSave";
            ptBtn.AutoSize = true;
            ptBtn.Click += new EventHandler(AutoDocSaveClick);
            ptBtn.Text = "Save " + bookMark.BookmarkName + " for " + senderButton.Text;
            

            this.flowLayoutPanel2.Controls.Add(richtxb);
            this.flowLayoutPanel2.Controls.Add(ptBtn);
        }
        private void AutoDocSaveClick(object sender, EventArgs e)
        {
            _autoDocSaveClick = sender as Button;

            
            var docData = new BookMarkData { BookMarkDataID = Guid.NewGuid().ToString("D"), AutoDocumentID = senderButton.Name, BookMarkID = bookMark.BookMarkID, BookMarkValue = richtxb.Text };

            _unitOfWork.BookMarkDataRepository.Add(docData);
            _unitOfWork.Save();
            MessageBox.Show("bookMark Saved...");
            ptBtn.Click -= this.AutoDocSaveClick;
        }



        

        
    }
}
