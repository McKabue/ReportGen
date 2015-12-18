namespace ReportGen
{
    partial class UserControlTaskPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label bookMarkTypeLabel;
            this.SaveBookmark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookMarkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoGenerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            bookMarkTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookMarkTypeLabel
            // 
            bookMarkTypeLabel.AutoSize = true;
            bookMarkTypeLabel.Location = new System.Drawing.Point(13, 164);
            bookMarkTypeLabel.Name = "bookMarkTypeLabel";
            bookMarkTypeLabel.Size = new System.Drawing.Size(89, 13);
            bookMarkTypeLabel.TabIndex = 8;
            bookMarkTypeLabel.Text = "Book Mark Type:";
            // 
            // SaveBookmark
            // 
            this.SaveBookmark.Location = new System.Drawing.Point(16, 253);
            this.SaveBookmark.Name = "SaveBookmark";
            this.SaveBookmark.Size = new System.Drawing.Size(114, 23);
            this.SaveBookmark.TabIndex = 12;
            this.SaveBookmark.Text = "Save BookMark";
            this.SaveBookmark.UseVisualStyleBackColor = true;
            this.SaveBookmark.Click += new System.EventHandler(this.SaveBookmark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name Of BookMark";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 10;
            // 
            // bookMarkTypeComboBox
            // 
            this.bookMarkTypeComboBox.FormattingEnabled = true;
            this.bookMarkTypeComboBox.Location = new System.Drawing.Point(151, 161);
            this.bookMarkTypeComboBox.Name = "bookMarkTypeComboBox";
            this.bookMarkTypeComboBox.Size = new System.Drawing.Size(159, 21);
            this.bookMarkTypeComboBox.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(401, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Book ark this Content?";
            // 
            // AutoGenerate
            // 
            this.AutoGenerate.Location = new System.Drawing.Point(19, 294);
            this.AutoGenerate.Name = "AutoGenerate";
            this.AutoGenerate.Size = new System.Drawing.Size(111, 23);
            this.AutoGenerate.TabIndex = 15;
            this.AutoGenerate.Text = "Auto-Generate";
            this.AutoGenerate.UseVisualStyleBackColor = true;
            this.AutoGenerate.Click += new System.EventHandler(this.AutoGenerate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AutoGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SaveBookmark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(bookMarkTypeLabel);
            this.Controls.Add(this.bookMarkTypeComboBox);
            this.Name = "UserControlTaskPane";
            this.Size = new System.Drawing.Size(429, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBookmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox bookMarkTypeComboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AutoGenerate;
        private System.Windows.Forms.Button button1;
    }
}
