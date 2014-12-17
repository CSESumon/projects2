namespace EmployeeSalary_App
{
    partial class EmployeeSalaryUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterSalaryTextbox = new System.Windows.Forms.TextBox();
            this.enterIDTextBox = new System.Windows.Forms.TextBox();
            this.showTotalTextbox = new System.Windows.Forms.TextBox();
            this.enterNameTextbox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary Amount";
            // 
            // enterSalaryTextbox
            // 
            this.enterSalaryTextbox.Location = new System.Drawing.Point(198, 118);
            this.enterSalaryTextbox.Name = "enterSalaryTextbox";
            this.enterSalaryTextbox.Size = new System.Drawing.Size(325, 20);
            this.enterSalaryTextbox.TabIndex = 4;
            // 
            // enterIDTextBox
            // 
            this.enterIDTextBox.Location = new System.Drawing.Point(198, 76);
            this.enterIDTextBox.Name = "enterIDTextBox";
            this.enterIDTextBox.Size = new System.Drawing.Size(325, 20);
            this.enterIDTextBox.TabIndex = 5;
            // 
            // showTotalTextbox
            // 
            this.showTotalTextbox.Location = new System.Drawing.Point(324, 401);
            this.showTotalTextbox.Name = "showTotalTextbox";
            this.showTotalTextbox.Size = new System.Drawing.Size(199, 20);
            this.showTotalTextbox.TabIndex = 6;
            // 
            // enterNameTextbox
            // 
            this.enterNameTextbox.Location = new System.Drawing.Point(198, 32);
            this.enterNameTextbox.Name = "enterNameTextbox";
            this.enterNameTextbox.Size = new System.Drawing.Size(325, 20);
            this.enterNameTextbox.TabIndex = 7;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(567, 165);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(567, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(153, 401);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(120, 23);
            this.totalButton.TabIndex = 11;
            this.totalButton.Text = "Total Amount";
            this.totalButton.UseVisualStyleBackColor = true;
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(198, 167);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(325, 200);
            this.textBoxShow.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 446);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.enterNameTextbox);
            this.Controls.Add(this.showTotalTextbox);
            this.Controls.Add(this.enterIDTextBox);
            this.Controls.Add(this.enterSalaryTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enterSalaryTextbox;
        private System.Windows.Forms.TextBox enterIDTextBox;
        private System.Windows.Forms.TextBox showTotalTextbox;
        private System.Windows.Forms.TextBox enterNameTextbox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.TextBox textBoxShow;
    }
}

