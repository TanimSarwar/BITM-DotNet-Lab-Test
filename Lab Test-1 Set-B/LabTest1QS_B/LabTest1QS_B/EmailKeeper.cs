using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1QS_B
{
    public partial class EmailKeeper : Form
    {
        public EmailKeeper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addTextBox.Text.Contains("@") && addTextBox.Text.Contains("."))
            {
                string[] row = { addTextBox.Text };
                var addListViewMail = new ListViewItem(row);
                addListView.Items.Add(addListViewMail);
                addTextBox.Text = "";   
            }
            else
            {
                MessageBox.Show("Entered Mail Address is not valid!!");
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
                foreach (ListViewItem lv in addListView.Items)
                {
                    if (searchTextBox.Text == lv.Text)
                    {
                        searchListView.Items.Add(searchTextBox.Text);
                    }
                }
                searchTextBox.Text = "";
        }
    }
}
