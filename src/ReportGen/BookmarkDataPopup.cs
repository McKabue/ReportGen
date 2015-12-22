﻿using ReportGen.Tools.DAL;
using System;
using System.Linq;
using System.Windows.Forms;
using ReportGen.Tools;
using ReportGen.Tools.Models;

namespace ReportGen
{
    public partial class BookmarkDataPopup : Form
    {
        public BookmarkDataPopup()
        {
            InitializeComponent();
        }
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public static Button senderButton;
        public static RichTextBox richtxb = new RichTextBox();
        public static Button ptBtn = new Button();
        //public static BookMark bookMark;
        Button _autoDocSaveClick;

        private void BookmarkDataPopup_Load(object sender, EventArgs e)
        {
            //var tabname = Globals.ThisAddIn._userControlTaskPane.textBox1.Text;

            //this.DataTypeTabControl.SelectedTab = this.DataTypeTabControl.TabPages["DateTime"];
            
            LoadDocumentButtons();
        }

        private void LoadDocumentButtons()
        {
            string path = Globals.ThisAddIn.Application.ActiveDocument.FullName;
            var _temp = _unitOfWork.TemplateRepository.FindBy(id => id.Path == path, "AutoDocuments");

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
        private void ButtonClick(object sender, EventArgs e)
        {
            senderButton = sender as Button;

            //var tabname = Globals.ThisAddIn._userControlTaskPane.textBox1.Text;
            //this.DataTypeTabControl.SelectedTab = this.DataTypeTabControl.TabPages[tabname];

            if (senderButton.Name.IsNullOrEmpty())
            {
                NewAutoDocument _newAutoDocument = new NewAutoDocument();

                if (_newAutoDocument.ShowDialog() == DialogResult.OK)
                {
                    string path = Globals.ThisAddIn.Application.ActiveDocument.FullName;
                    var _temp = _unitOfWork.TemplateRepository.FindBy(id => id.Path == path);
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
            //var thisAutoDoc = _unitOfWork.TemplateRepository.FindBy(id => id.Path == Globals.ThisAddIn.Application.ActiveDocument.FullName, "BookMarks");
            //var previousBookMarkData = _unitOfWork.BookMarkDataRepository.FindBy(id => id.BookMarkID == thisAutoDoc.BookMarks.Where(bid => bid.BookmarkName == Globals.ThisAddIn._userControlTaskPane.textBox1.Text).FirstOrDefault().BookMarkID);
            //richtxb.Dock = DockStyle.Top;
            //richtxb.Size = new Size(2000, 50);
            richtxb.Width = (flowLayoutPanel2.Width - 8);
            richtxb.Name = "AutoDocValue";
            richtxb.Text = "previousBookMarkData.BookMarkValue"; //"previous input...";



            ptBtn.Name = "AutoDocSave";
            ptBtn.Click += new EventHandler(AutoDocSaveClick);
            ptBtn.Text = "Save";
            

            this.flowLayoutPanel2.Controls.Add(richtxb);
            this.flowLayoutPanel2.Controls.Add(ptBtn);
        }
        private void AutoDocSaveClick(object sender, EventArgs e)
        {
            _autoDocSaveClick = sender as Button;


            var _bk = _unitOfWork.BookMarkRepository.FindBy(id => id.BookmarkName == Globals.ThisAddIn._userControlTaskPane.textBox1.Text);
            var docData = new BookMarkData { BookMarkDataID = Guid.NewGuid().ToString("D"), AutoDocumentID = senderButton.Name, BookMarkID = _bk.BookMarkID, BookMarkValue = richtxb.Text };

            _unitOfWork.BookMarkDataRepository.Add(docData);
            _unitOfWork.Save();
            MessageBox.Show("bookMark Saved...");
            ptBtn.Click -= this.AutoDocSaveClick;
        }



        

        
    }
}