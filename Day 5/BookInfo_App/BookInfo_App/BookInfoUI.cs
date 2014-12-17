using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfo_App
{
    public partial class BookInfoUI : Form
    {

        Hashtable aHashtable = new Hashtable();
        public BookInfoUI()
        {
            InitializeComponent();
        }

        private void label2Isbn_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (aHashtable.ContainsKey(textBoxAddIsbn.Text))
            {
                MessageBox.Show("This ISBN Number already recorded");
            }
            else
            {
                aHashtable.Add(textBoxAddIsbn.Text, textBoxAddBook.Text);
                MessageBox.Show("Your Data is saved");
            }
           

            textBoxAddBook.Clear();
            textBoxAddIsbn.Clear();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (aHashtable.ContainsKey(textBoxShowIsbn.Text))
            {
                string bookDetails = aHashtable[textBoxShowIsbn.Text].ToString();
                textBoxDetails.Text = bookDetails;
            }
            else
            {
                MessageBox.Show("Not found");
            }
             
            //textBoxDetails.Clear();
        }
    }
}
