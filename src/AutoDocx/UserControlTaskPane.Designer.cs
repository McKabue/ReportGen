namespace AutoDocx
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
            this.TaskPaneTabControl = new System.Windows.Forms.TabControl();
            this.Templating = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveBookmark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookMarkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Binding = new System.Windows.Forms.TabPage();
            this.SelectAllBindingAutodocuments = new System.Windows.Forms.CheckBox();
            this.AutoGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Reviews = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.emailFrom = new System.Windows.Forms.TextBox();
            this.textBox_Attachment = new System.Windows.Forms.TextBox();
            this.AddAttachment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTitle = new System.Windows.Forms.TextBox();
            this.emailSubject = new System.Windows.Forms.ComboBox();
            this.emailBody = new System.Windows.Forms.RichTextBox();
            this.emailSend = new System.Windows.Forms.Button();
            this.BrowseAttachment = new System.Windows.Forms.Button();
            bookMarkTypeLabel = new System.Windows.Forms.Label();
            this.TaskPaneTabControl.SuspendLayout();
            this.Templating.SuspendLayout();
            this.Binding.SuspendLayout();
            this.Reviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookMarkTypeLabel
            // 
            bookMarkTypeLabel.AutoSize = true;
            bookMarkTypeLabel.Location = new System.Drawing.Point(9, 143);
            bookMarkTypeLabel.Name = "bookMarkTypeLabel";
            bookMarkTypeLabel.Size = new System.Drawing.Size(89, 13);
            bookMarkTypeLabel.TabIndex = 16;
            bookMarkTypeLabel.Text = "Book Mark Type:";
            // 
            // TaskPaneTabControl
            // 
            this.TaskPaneTabControl.Controls.Add(this.Templating);
            this.TaskPaneTabControl.Controls.Add(this.Binding);
            this.TaskPaneTabControl.Controls.Add(this.Reviews);
            this.TaskPaneTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskPaneTabControl.Location = new System.Drawing.Point(0, 0);
            this.TaskPaneTabControl.Name = "TaskPaneTabControl";
            this.TaskPaneTabControl.SelectedIndex = 0;
            this.TaskPaneTabControl.Size = new System.Drawing.Size(429, 524);
            this.TaskPaneTabControl.TabIndex = 17;
            // 
            // Templating
            // 
            this.Templating.Controls.Add(this.label2);
            this.Templating.Controls.Add(this.richTextBox1);
            this.Templating.Controls.Add(this.SaveBookmark);
            this.Templating.Controls.Add(this.label1);
            this.Templating.Controls.Add(this.textBox1);
            this.Templating.Controls.Add(bookMarkTypeLabel);
            this.Templating.Controls.Add(this.bookMarkTypeComboBox);
            this.Templating.Location = new System.Drawing.Point(4, 22);
            this.Templating.Name = "Templating";
            this.Templating.Padding = new System.Windows.Forms.Padding(3);
            this.Templating.Size = new System.Drawing.Size(421, 498);
            this.Templating.TabIndex = 0;
            this.Templating.Text = "Templating";
            this.Templating.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Book ark this Content?";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(406, 96);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // SaveBookmark
            // 
            this.SaveBookmark.Location = new System.Drawing.Point(12, 232);
            this.SaveBookmark.Name = "SaveBookmark";
            this.SaveBookmark.Size = new System.Drawing.Size(114, 23);
            this.SaveBookmark.TabIndex = 20;
            this.SaveBookmark.Text = "Save BookMark";
            this.SaveBookmark.UseVisualStyleBackColor = true;
            this.SaveBookmark.Click += new System.EventHandler(this.SaveBookmark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name Of BookMark";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 18;
            // 
            // bookMarkTypeComboBox
            // 
            this.bookMarkTypeComboBox.FormattingEnabled = true;
            this.bookMarkTypeComboBox.Location = new System.Drawing.Point(147, 140);
            this.bookMarkTypeComboBox.Name = "bookMarkTypeComboBox";
            this.bookMarkTypeComboBox.Size = new System.Drawing.Size(159, 21);
            this.bookMarkTypeComboBox.TabIndex = 17;
            // 
            // Binding
            // 
            this.Binding.Controls.Add(this.SelectAllBindingAutodocuments);
            this.Binding.Controls.Add(this.AutoGenerate);
            this.Binding.Controls.Add(this.label3);
            this.Binding.Controls.Add(this.treeView1);
            this.Binding.Location = new System.Drawing.Point(4, 22);
            this.Binding.Name = "Binding";
            this.Binding.Padding = new System.Windows.Forms.Padding(3);
            this.Binding.Size = new System.Drawing.Size(421, 498);
            this.Binding.TabIndex = 1;
            this.Binding.Text = "Binding";
            this.Binding.UseVisualStyleBackColor = true;
            // 
            // SelectAllBindingAutodocuments
            // 
            this.SelectAllBindingAutodocuments.AutoSize = true;
            this.SelectAllBindingAutodocuments.Location = new System.Drawing.Point(13, 33);
            this.SelectAllBindingAutodocuments.Name = "SelectAllBindingAutodocuments";
            this.SelectAllBindingAutodocuments.Size = new System.Drawing.Size(147, 17);
            this.SelectAllBindingAutodocuments.TabIndex = 25;
            this.SelectAllBindingAutodocuments.Text = "Select All Autodocuments";
            this.SelectAllBindingAutodocuments.UseVisualStyleBackColor = true;
            this.SelectAllBindingAutodocuments.CheckedChanged += new System.EventHandler(this.SelectAllBindingAutodocuments_CheckedChanged);
            // 
            // AutoGenerate
            // 
            this.AutoGenerate.AutoSize = true;
            this.AutoGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoGenerate.Location = new System.Drawing.Point(297, 3);
            this.AutoGenerate.Name = "AutoGenerate";
            this.AutoGenerate.Size = new System.Drawing.Size(118, 26);
            this.AutoGenerate.TabIndex = 24;
            this.AutoGenerate.Text = "Auto-Generate";
            this.AutoGenerate.UseVisualStyleBackColor = true;
            this.AutoGenerate.Click += new System.EventHandler(this.AutoGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "AutoDocs Binding Data Infomation";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Location = new System.Drawing.Point(3, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(415, 460);
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Reviews
            // 
            this.Reviews.AutoScroll = true;
            this.Reviews.Controls.Add(this.BrowseAttachment);
            this.Reviews.Controls.Add(this.label8);
            this.Reviews.Controls.Add(this.emailFrom);
            this.Reviews.Controls.Add(this.textBox_Attachment);
            this.Reviews.Controls.Add(this.AddAttachment);
            this.Reviews.Controls.Add(this.label7);
            this.Reviews.Controls.Add(this.label6);
            this.Reviews.Controls.Add(this.label5);
            this.Reviews.Controls.Add(this.label4);
            this.Reviews.Controls.Add(this.emailTitle);
            this.Reviews.Controls.Add(this.emailSubject);
            this.Reviews.Controls.Add(this.emailBody);
            this.Reviews.Controls.Add(this.emailSend);
            this.Reviews.Location = new System.Drawing.Point(4, 22);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(421, 498);
            this.Reviews.TabIndex = 2;
            this.Reviews.Text = "Reviews";
            this.Reviews.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "From";
            // 
            // emailFrom
            // 
            this.emailFrom.Location = new System.Drawing.Point(79, 71);
            this.emailFrom.Name = "emailFrom";
            this.emailFrom.Size = new System.Drawing.Size(343, 20);
            this.emailFrom.TabIndex = 11;
            // 
            // textBox_Attachment
            // 
            this.textBox_Attachment.Location = new System.Drawing.Point(79, 377);
            this.textBox_Attachment.Name = "textBox_Attachment";
            this.textBox_Attachment.Size = new System.Drawing.Size(281, 20);
            this.textBox_Attachment.TabIndex = 10;
            // 
            // AddAttachment
            // 
            this.AddAttachment.AutoSize = true;
            this.AddAttachment.Location = new System.Drawing.Point(325, 406);
            this.AddAttachment.Name = "AddAttachment";
            this.AddAttachment.Size = new System.Drawing.Size(93, 23);
            this.AddAttachment.TabIndex = 9;
            this.AddAttachment.Text = "Add Attachment";
            this.AddAttachment.UseVisualStyleBackColor = true;
            this.AddAttachment.Click += new System.EventHandler(this.AddAttachment_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(415, 54);
            this.label7.TabIndex = 8;
            this.label7.Text = "Send Email to Request New Features, Improvements and Recommedations...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // emailTitle
            // 
            this.emailTitle.Location = new System.Drawing.Point(79, 111);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(343, 20);
            this.emailTitle.TabIndex = 4;
            // 
            // emailSubject
            // 
            this.emailSubject.FormattingEnabled = true;
            this.emailSubject.Items.AddRange(new object[] {
            "New Feature",
            "Improvement",
            "Help",
            "Other"});
            this.emailSubject.Location = new System.Drawing.Point(79, 154);
            this.emailSubject.Name = "emailSubject";
            this.emailSubject.Size = new System.Drawing.Size(140, 21);
            this.emailSubject.TabIndex = 3;
            // 
            // emailBody
            // 
            this.emailBody.Location = new System.Drawing.Point(79, 201);
            this.emailBody.Name = "emailBody";
            this.emailBody.Size = new System.Drawing.Size(343, 155);
            this.emailBody.TabIndex = 2;
            this.emailBody.Text = "";
            // 
            // emailSend
            // 
            this.emailSend.AutoSize = true;
            this.emailSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSend.Location = new System.Drawing.Point(293, 452);
            this.emailSend.Name = "emailSend";
            this.emailSend.Size = new System.Drawing.Size(125, 30);
            this.emailSend.TabIndex = 1;
            this.emailSend.Text = "Send Email...";
            this.emailSend.UseVisualStyleBackColor = true;
            this.emailSend.Click += new System.EventHandler(this.emailSend_Click);
            // 
            // BrowseAttachment
            // 
            this.BrowseAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseAttachment.Location = new System.Drawing.Point(366, 375);
            this.BrowseAttachment.Name = "BrowseAttachment";
            this.BrowseAttachment.Size = new System.Drawing.Size(52, 23);
            this.BrowseAttachment.TabIndex = 13;
            this.BrowseAttachment.Text = "Browse";
            this.BrowseAttachment.UseVisualStyleBackColor = true;
            this.BrowseAttachment.Click += new System.EventHandler(this.BrowseAttachment_Click);
            // 
            // UserControlTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskPaneTabControl);
            this.Name = "UserControlTaskPane";
            this.Size = new System.Drawing.Size(429, 524);
            this.TaskPaneTabControl.ResumeLayout(false);
            this.Templating.ResumeLayout(false);
            this.Templating.PerformLayout();
            this.Binding.ResumeLayout(false);
            this.Binding.PerformLayout();
            this.Reviews.ResumeLayout(false);
            this.Reviews.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Templating;
        private System.Windows.Forms.TabPage Binding;
        private System.Windows.Forms.TabPage Reviews;
        public System.Windows.Forms.TabControl TaskPaneTabControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBookmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bookMarkTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button emailSend;
        private System.Windows.Forms.Button AutoGenerate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox emailTitle;
        public System.Windows.Forms.ComboBox emailSubject;
        public System.Windows.Forms.RichTextBox emailBody;
        private System.Windows.Forms.Button AddAttachment;
        private System.Windows.Forms.TextBox textBox_Attachment;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox emailFrom;
        private System.Windows.Forms.CheckBox SelectAllBindingAutodocuments;
        private System.Windows.Forms.Button BrowseAttachment;
    }
}
