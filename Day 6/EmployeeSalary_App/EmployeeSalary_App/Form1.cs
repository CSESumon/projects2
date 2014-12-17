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

namespace EmployeeSalary_App
{
    public partial class EmployeeSalaryUi : Form
    {
        public EmployeeSalaryUi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string employInfo;
        

        private void button2_Click(object sender, EventArgs e)
        {
            string name = enterNameTextbox.Text;
            string id = enterIDTextBox.Text;
            string salary = enterSalaryTextbox.Text;

            string path = @"D:\info.txt";
            FileStream aFileStream = new FileStream(path , FileMode.Append);

            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(name + " , " + id + " , " + salary);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double sum = 0;
            string path = @"D:\info.txt";

            FileStream aFileStream = new FileStream(path, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            textBoxShow.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                employInfo = aStreamReader.ReadLine();
                textBoxShow.Items.Add(employInfo);
                string[] Info = employInfo.Split(',');
                sum += Convert.ToDouble(Info[2]);
                
            }
            showTotalTextbox.Text = Convert.ToString(sum);
            aStreamReader.Close();
            aFileStream.Close();

        }
    }
}
