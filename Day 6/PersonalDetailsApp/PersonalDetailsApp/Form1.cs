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
using CSVLib;

namespace PersonalDetailsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path = @"F:\ASP.Net\PersonalInfo.txt";
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string pno = contactTtextBox.Text;
            string hno = homeContactNumber.Text;
            string home = homeAddress.Text;

            if (File.Exists(path))
            {
                bool unique = UniqueChek(pno);

                if (unique==true)
                {
                    FileStream aFileStream = new FileStream(path , FileMode.Append);
                    CsvFileWriter aCsvFileWriter=new CsvFileWriter(aFileStream);

                    List<string> aList = new List<string>();
                    
                    aList.Add(name);
                    aList.Add(email);
                    aList.Add(pno);
                    aList.Add(hno);
                    aList.Add(home);

                    aCsvFileWriter.WriteRow(aList);
                    aFileStream.Close();

                    NameTextBox.Clear();
                    EmailTextBox.Clear();
                    contactTtextBox.Clear();
                    homeContactNumber.Clear();
                    homeAddress.Clear();

                    MessageBox.Show("Your Data has been saved");
                }
                else
                {
                    MessageBox.Show("This Number already Exists");
                }
                
            }
        }

        private bool UniqueChek(string personalNo)
        {
            int personalNoInt = Convert.ToInt32(personalNo);
            FileStream aFileStream= new FileStream(path , FileMode.Open);
            CsvFileReader aCsvFileReader=new CsvFileReader(aFileStream);

            List<string> aList= new List<string>();
            showLlistBox.Items.Clear();
            bool a = true;
            while (aCsvFileReader.ReadRow(aList))
            {
                int personalnum = Convert.ToInt32(aList[2]);

                if (personalNoInt==personalnum)
                {
                    a = false;
                    break;
                }
                else
                {
                    a = true;
                }
            }
            aFileStream.Close();
            return a;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aCsvFileReader= new CsvFileReader(aFileStream);

            List<string> aList= new List<string>();
            while (aCsvFileReader.ReadRow(aList))
            {
                string name = aList[0];
                string email = aList[1];
                string pno = aList[2];
                string hno = aList[3];
                string home = aList[4];

                showLlistBox.Items.Add(name + " ," + email + " , " + pno + " , " + hno + " , " + home);

            }
            aFileStream.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
