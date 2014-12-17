namespace BookInfo_App
{
    partial class BookInfoUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAddBook = new System.Windows.Forms.TextBox();
            this.textBoxAddIsbn = new System.Windows.Forms.TextBox();
            this.label1Isbn = new System.Windows.Forms.Label();
            this.label1AddBook = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2Details = new System.Windows.Forms.Label();
            this.textBoxShowIsbn = new System.Windows.Forms.TextBox();
            this.label2Isbn = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxAddBook);
            this.groupBox1.Controls.Add(this.textBoxAddIsbn);
            this.groupBox1.Controls.Add(this.label1Isbn);
            this.groupBox1.Controls.Add(this.label1AddBook);
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book Informatiion";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(479, 61);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = " Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAddBook
            // 
            this.textBoxAddBook.Location = new System.Drawing.Point(176, 92);
            this.textBoxAddBook.Name = "textBoxAddBook";
            this.textBoxAddBook.Size = new System.Drawing.Size(249, 20);
            this.textBoxAddBook.TabIndex = 1;
            // 
            // textBoxAddIsbn
            // 
            this.textBoxAddIsbn.Location = new System.Drawing.Point(176, 33);
            this.textBoxAddIsbn.Name = "textBoxAddIsbn";
            this.textBoxAddIsbn.Size = new System.Drawing.Size(249, 20);
            this.textBoxAddIsbn.TabIndex = 0;
            // 
            // label1Isbn
            // 
            this.label1Isbn.AutoSize = true;
            this.label1Isbn.Location = new System.Drawing.Point(55, 33);
            this.label1Isbn.Name = "label1Isbn";
            this.label1Isbn.Size = new System.Drawing.Size(32, 13);
            this.label1Isbn.TabIndex = 1;
            this.label1Isbn.Text = "ISBN";
            // 
            // label1AddBook
            // 
            this.label1AddBook.AutoSize = true;
            this.label1AddBook.Location = new System.Drawing.Point(55, 92);
            this.label1AddBook.Name = "label1AddBook";
            this.label1AddBook.Size = new System.Drawing.Size(67, 13);
            this.label1AddBook.TabIndex = 2;
            this.label1AddBook.Text = "Book Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFind);
            this.groupBox2.Controls.Add(this.label2Details);
            this.groupBox2.Controls.Add(this.textBoxShowIsbn);
            this.groupBox2.Controls.Add(this.label2Isbn);
            this.groupBox2.Controls.Add(this.textBoxDetails);
            this.groupBox2.Location = new System.Drawing.Point(31, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(479, 60);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2Details
            // 
            this.label2Details.AutoSize = true;
            this.label2Details.Location = new System.Drawing.Point(55, 88);
            this.label2Details.Name = "label2Details";
            this.label2Details.Size = new System.Drawing.Size(39, 13);
            this.label2Details.TabIndex = 5;
            this.label2Details.Text = "Details";
            // 
            // textBoxShowIsbn
            // 
            this.textBoxShowIsbn.Location = new System.Drawing.Point(176, 39);
            this.textBoxShowIsbn.Name = "textBoxShowIsbn";
            this.textBoxShowIsbn.Size = new System.Drawing.Size(249, 20);
            this.textBoxShowIsbn.TabIndex = 0;
            // 
            // label2Isbn
            // 
            this.label2Isbn.AutoSize = true;
            this.label2Isbn.Location = new System.Drawing.Point(55, 39);
            this.label2Isbn.Name = "label2Isbn";
            this.label2Isbn.Size = new System.Drawing.Size(32, 13);
            this.label2Isbn.TabIndex = 4;
            this.label2Isbn.Text = "ISBN";
            this.label2Isbn.Click += new System.EventHandler(this.label2Isbn_Click);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(176, 88);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(249, 20);
            this.textBoxDetails.TabIndex = 3;
            // 
            // BookInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookInfoUI";
            this.Text = "BookInfoUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddBook;
        private System.Windows.Forms.TextBox textBoxAddIsbn;
        private System.Windows.Forms.Label label1Isbn;
        private System.Windows.Forms.Label label1AddBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2Details;
        private System.Windows.Forms.TextBox textBoxShowIsbn;
        private System.Windows.Forms.Label label2Isbn;
        private System.Windows.Forms.TextBox textBoxDetails;
    }
}

