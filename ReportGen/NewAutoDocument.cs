﻿using ReportGen.Tools.DAL;
using System;
using System.Windows.Forms;
using ReportGen.Tools;

namespace ReportGen
{
    public partial class NewAutoDocument : Form
    {
        public NewAutoDocument()
        {
            InitializeComponent();
        }

        private UnitOfWork _unitOfWork = new UnitOfWork();

        private void SaveAutoDocument_Click(object sender, EventArgs e)
        {
            if (!AutoDocumentName.Text.IsNullOrEmpty())
            {
                this.DialogResult = DialogResult.OK;
            }


        }
    }
}