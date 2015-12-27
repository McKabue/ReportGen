namespace AutoDocx
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DateTime = new System.Windows.Forms.TabPage();
            this.DataTypeTabControl.SuspendLayout();
            this.PlainText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 47);
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
            this.DataTypeTabControl.Size = new System.Drawing.Size(812, 395);
            this.DataTypeTabControl.TabIndex = 1;
            // 
            // PlainText
            // 
            this.PlainText.Controls.Add(this.splitContainer1);
            this.PlainText.Location = new System.Drawing.Point(4, 22);
            this.PlainText.Name = "PlainText";
            this.PlainText.Padding = new System.Windows.Forms.Padding(3);
            this.PlainText.Size = new System.Drawing.Size(804, 369);
            this.PlainText.TabIndex = 0;
            this.PlainText.Text = "PlainText";
            this.PlainText.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(798, 363);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 363);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(636, 363);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // DateTime
            // 
            this.DateTime.Controls.Add(this.dateTimePicker1);
            this.DateTime.Location = new System.Drawing.Point(4, 22);
            this.DateTime.Name = "DateTime";
            this.DateTime.Padding = new System.Windows.Forms.Padding(3);
            this.DateTime.Size = new System.Drawing.Size(804, 369);
            this.DateTime.TabIndex = 1;
            this.DateTime.Text = "DateTime";
            this.DateTime.UseVisualStyleBackColor = true;
            // 
            // BookmarkDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 395);
            this.Controls.Add(this.DataTypeTabControl);
            this.Name = "BookmarkDataPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookmarkDataPopup";
            this.Load += new System.EventHandler(this.BookmarkDataPopup_Load);
            this.DataTypeTabControl.ResumeLayout(false);
            this.PlainText.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DateTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TabControl DataTypeTabControl;
        public System.Windows.Forms.TabPage PlainText;
        private System.Windows.Forms.TabPage DateTime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}