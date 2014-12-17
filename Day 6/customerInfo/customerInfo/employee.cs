using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeInfo
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private string employeeInfo;
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string ID = IDTextBox.Text;
            string salary = salaryTextBox.Text;
            string path = @"G:\info.txt";
            FileStream aFileStream = new FileStream(path,FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(name+ ","+ID+ ","+salary);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            double sum = 0;
            string path = @"G:\info.txt";
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            detailsListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                employeeInfo = aStreamReader.ReadLine();
                detailsListBox.Items.Add(employeeInfo);
                string[] Info = employeeInfo.Split(',');
                sum += Convert.ToDouble(Info[2]);
                
            }
            totalAmountTextBox.Text = Convert.ToString(sum);
            aStreamReader.Close();
            aFileStream.Close();

            
        }

        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
