using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoDictionary_App
{
    public partial class DictionaryUi : Form
    {
        public DictionaryUi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Dictionary<int ,string> aDictionary= new Dictionary<int, string>();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (aDictionary.ContainsKey(Convert.ToInt32(textBoxInput.Text)))
            {
                MessageBox.Show("This data already recorded");
            }
            else
            {
                aDictionary.Add(Convert.ToInt32(textBoxInput.Text), richTextBoxDetails.Text);
                MessageBox.Show("Your data recorded");
                richTextBoxDetails.Clear();
                textBoxInput.Clear();
            }
            

        }

        private void textBoxShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (aDictionary.ContainsKey(Convert.ToInt32(textBoxSearchId.Text)))
            {
                int id = Convert.ToInt32(textBoxSearchId.Text);
                MessageBox.Show(aDictionary[id]);
            }
            else
            {
                MessageBox.Show("There are no record for this id");
            }
            
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            
            if (aDictionary.ContainsKey(Convert.ToInt32(textBoxSearchId.Text)))
            {

                string showAll = " ";
                foreach (KeyValuePair<int, string>pair in aDictionary)
                {
                    showAll +=  pair.Key+ " " + pair.Value + "\n";
                }
                MessageBox.Show(showAll);
            }
            else
            {
                MessageBox.Show("Unvalide ID");
            }
        }
    }
}
