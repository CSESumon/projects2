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

namespace SaveInfoInFile_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxInputInfo.Text;
             StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            FileStream aFileStream = new FileStream(path , FileMode.Append);
            string path = @"D:\info.txt";



        }
    }
}
