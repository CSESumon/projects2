namespace SaveInfoInFile_App
{
    partial class Form1
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxInputInfo = new System.Windows.Forms.TextBox();
            this.richTextBoxShowAll = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(44, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(78, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Coustomer Info";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 13);
            this.label.TabIndex = 1;
            this.label.Text = "(Name and Phone No)";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxInputInfo
            // 
            this.textBoxInputInfo.Location = new System.Drawing.Point(162, 12);
            this.textBoxInputInfo.Name = "textBoxInputInfo";
            this.textBoxInputInfo.Size = new System.Drawing.Size(384, 20);
            this.textBoxInputInfo.TabIndex = 2;
            // 
            // richTextBoxShowAll
            // 
            this.richTextBoxShowAll.Location = new System.Drawing.Point(162, 73);
            this.richTextBoxShowAll.Name = "richTextBoxShowAll";
            this.richTextBoxShowAll.Size = new System.Drawing.Size(384, 263);
            this.richTextBoxShowAll.TabIndex = 3;
            this.richTextBoxShowAll.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(581, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(581, 71);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Show All";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 378);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxShowAll);
            this.Controls.Add(this.textBoxInputInfo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxInputInfo;
        private System.Windows.Forms.RichTextBox richTextBoxShowAll;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShow;
    }
}

