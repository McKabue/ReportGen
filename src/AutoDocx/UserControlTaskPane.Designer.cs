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
            this.AutoGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Help = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            bookMarkTypeLabel = new System.Windows.Forms.Label();
            this.TaskPaneTabControl.SuspendLayout();
            this.Templating.SuspendLayout();
            this.Binding.SuspendLayout();
            this.Help.SuspendLayout();
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
            this.TaskPaneTabControl.Controls.Add(this.Help);
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
            this.treeView1.Location = new System.Drawing.Point(3, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(415, 470);
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label7);
            this.Help.Controls.Add(this.label6);
            this.Help.Controls.Add(this.label5);
            this.Help.Controls.Add(this.label4);
            this.Help.Controls.Add(this.textBox2);
            this.Help.Controls.Add(this.comboBox1);
            this.Help.Controls.Add(this.richTextBox2);
            this.Help.Controls.Add(this.button1);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(421, 498);
            this.Help.TabIndex = 2;
            this.Help.Text = "Reviews";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(415, 86);
            this.label7.TabIndex = 8;
            this.label7.Text = "Are there Improvements or Features that you need to see added to this plugin? Fil" +
    "l out your Recommedations in the input sections below and send an email...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "New Feature",
            "Improvement",
            "Help",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(79, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(79, 187);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(339, 250);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Templating;
        private System.Windows.Forms.TabPage Binding;
        private System.Windows.Forms.TabPage Help;
        public System.Windows.Forms.TabControl TaskPaneTabControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBookmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bookMarkTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AutoGenerate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
    }
}
