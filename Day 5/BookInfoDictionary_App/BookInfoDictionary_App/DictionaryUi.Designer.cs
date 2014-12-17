namespace BookInfoDictionary_App
{
    partial class DictionaryUi
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
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.showId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.Location = new System.Drawing.Point(150, 84);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.Size = new System.Drawing.Size(330, 151);
            this.richTextBoxDetails.TabIndex = 2;
            this.richTextBoxDetails.Text = "";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(150, 38);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(330, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.Location = new System.Drawing.Point(150, 306);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(330, 20);
            this.textBoxSearchId.TabIndex = 4;
            this.textBoxSearchId.TextChanged += new System.EventHandler(this.textBoxShow_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(516, 212);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(273, 389);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 6;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(516, 303);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(35, 38);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "ID";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(35, 75);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(39, 13);
            this.labelDetails.TabIndex = 7;
            this.labelDetails.Text = "Details";
            this.labelDetails.Click += new System.EventHandler(this.label2_Click);
            // 
            // showId
            // 
            this.showId.AutoSize = true;
            this.showId.Location = new System.Drawing.Point(44, 306);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(18, 13);
            this.showId.TabIndex = 8;
            this.showId.Text = "ID";
            // 
            // DictionaryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.showId);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.richTextBoxDetails);
            this.Name = "DictionaryUi";
            this.Text = "DictionaryUi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label showId;
    }
}

