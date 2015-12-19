namespace ReportGen
{
    partial class BookmarkDataPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DataTypeTabControl = new System.Windows.Forms.TabControl();
            this.PlainText = new System.Windows.Forms.TabPage();
            this.DateTime = new System.Windows.Forms.TabPage();
            this.DataTypeTabControl.SuspendLayout();
            this.DateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DataTypeTabControl
            // 
            this.DataTypeTabControl.Controls.Add(this.PlainText);
            this.DataTypeTabControl.Controls.Add(this.DateTime);
            this.DataTypeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTypeTabControl.Location = new System.Drawing.Point(0, 0);
            this.DataTypeTabControl.Name = "DataTypeTabControl";
            this.DataTypeTabControl.SelectedIndex = 0;
            this.DataTypeTabControl.Size = new System.Drawing.Size(513, 348);
            this.DataTypeTabControl.TabIndex = 1;
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(4, 22);
            this.PlainText.Name = "PlainText";
            this.PlainText.Padding = new System.Windows.Forms.Padding(3);
            this.PlainText.Size = new System.Drawing.Size(505, 322);
            this.PlainText.TabIndex = 0;
            this.PlainText.Text = "PlainText";
            this.PlainText.UseVisualStyleBackColor = true;
            // 
            // DateTime
            // 
            this.DateTime.Controls.Add(this.dateTimePicker1);
            this.DateTime.Location = new System.Drawing.Point(4, 22);
            this.DateTime.Name = "DateTime";
            this.DateTime.Padding = new System.Windows.Forms.Padding(3);
            this.DateTime.Size = new System.Drawing.Size(505, 322);
            this.DateTime.TabIndex = 1;
            this.DateTime.Text = "DateTime";
            this.DateTime.UseVisualStyleBackColor = true;
            // 
            // BookmarkDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.DataTypeTabControl);
            this.Name = "BookmarkDataPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookmarkDataPopup";
            this.Load += new System.EventHandler(this.BookmarkDataPopup_Load);
            this.DataTypeTabControl.ResumeLayout(false);
            this.DateTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TabControl DataTypeTabControl;
        public System.Windows.Forms.TabPage PlainText;
        private System.Windows.Forms.TabPage DateTime;
    }
}