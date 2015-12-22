namespace ReportGen
{
    partial class SaveTemplateForm
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
            this.TName = new System.Windows.Forms.TextBox();
            this.TemplateSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoDocs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AutoDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(147, 36);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(158, 20);
            this.TName.TabIndex = 0;
            // 
            // TemplateSave
            // 
            this.TemplateSave.Location = new System.Drawing.Point(88, 122);
            this.TemplateSave.Name = "TemplateSave";
            this.TemplateSave.Size = new System.Drawing.Size(114, 23);
            this.TemplateSave.TabIndex = 1;
            this.TemplateSave.Text = "Save Template";
            this.TemplateSave.UseVisualStyleBackColor = true;
            this.TemplateSave.Click += new System.EventHandler(this.TemplateSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name Of Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Documents";
            // 
            // AutoDocs
            // 
            this.AutoDocs.Location = new System.Drawing.Point(147, 70);
            this.AutoDocs.Name = "AutoDocs";
            this.AutoDocs.Size = new System.Drawing.Size(158, 20);
            this.AutoDocs.TabIndex = 5;
            // 
            // SaveTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 172);
            this.Controls.Add(this.AutoDocs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemplateSave);
            this.Controls.Add(this.TName);
            this.Name = "SaveTemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveTemplateForm";
            this.Load += new System.EventHandler(this.SaveTemplateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Button TemplateSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown AutoDocs;
    }
}