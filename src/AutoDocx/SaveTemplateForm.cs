using System;
using System.Windows.Forms;

namespace AutoDocx
{
    public partial class SaveTemplateForm : Form
    {
        public SaveTemplateForm()
        {
            InitializeComponent();
        }

        private void SaveTemplateForm_Load(object sender, EventArgs e)
        {
            //this.textBox1
        }

        private void TemplateSave_Click(object sender, EventArgs e)
        {
            
                if (this.TName.Text != "")
                {
                  this.DialogResult = DialogResult.OK;
                }






        }
    }
}
