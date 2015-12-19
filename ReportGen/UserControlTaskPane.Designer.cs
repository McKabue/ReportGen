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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Node9");
            this.TaskPaneTabControl = new System.Windows.Forms.TabControl();
            this.Templating = new System.Windows.Forms.TabPage();
            this.AutoGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveBookmark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookMarkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Binding = new System.Windows.Forms.TabPage();
            this.Help = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            bookMarkTypeLabel = new System.Windows.Forms.Label();
            this.TaskPaneTabControl.SuspendLayout();
            this.Templating.SuspendLayout();
            this.Binding.SuspendLayout();
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
            this.Templating.Controls.Add(this.AutoGenerate);
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
            // AutoGenerate
            // 
            this.AutoGenerate.Location = new System.Drawing.Point(15, 273);
            this.AutoGenerate.Name = "AutoGenerate";
            this.AutoGenerate.Size = new System.Drawing.Size(111, 23);
            this.AutoGenerate.TabIndex = 23;
            this.AutoGenerate.Text = "Auto-Generate";
            this.AutoGenerate.UseVisualStyleBackColor = true;
            this.AutoGenerate.Click += new System.EventHandler(this.AutoGenerate_Click);
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
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(418, 492);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 33);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "Node1";
            treeNode21.Text = "Node1";
            treeNode22.Name = "Node4";
            treeNode22.Text = "Node4";
            treeNode23.Name = "Node5";
            treeNode23.Text = "Node5";
            treeNode24.Name = "Node2";
            treeNode24.Text = "Node2";
            treeNode25.Name = "Node3";
            treeNode25.Text = "Node3";
            treeNode26.Name = "Node0";
            treeNode26.Text = "Node0";
            treeNode27.Name = "Node7";
            treeNode27.Text = "Node7";
            treeNode28.Name = "Node8";
            treeNode28.Text = "Node8";
            treeNode29.Name = "Node6";
            treeNode29.Text = "Node6";
            treeNode30.Name = "Node9";
            treeNode30.Text = "Node9";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode29,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "AutoDoc Data Info";
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Templating;
        private System.Windows.Forms.TabPage Binding;
        private System.Windows.Forms.TabPage Help;
        public System.Windows.Forms.TabControl TaskPaneTabControl;
        private System.Windows.Forms.Button AutoGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBookmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bookMarkTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}
