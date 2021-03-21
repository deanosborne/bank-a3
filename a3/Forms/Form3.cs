using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a3.Models;
using a3.Forms;
using System.IO;

namespace a3
{
    public partial class Form3 : Form1
    {
        Controller _controller = new Controller();
        Customer c = new Customer();
        public int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        //write from controller list
        //Display data on load
        private void Form3_Load(object sender, EventArgs e)
        {
            _controller.Display(listView1, _controller);

        }

        //add new user
        private void button1_Click(object sender, EventArgs e)
        {
            _controller.Add(customer_name.Text);
            _controller.ToListview(listView1, _controller);
            _controller.WriteFile(listView1);
        }

        //edit user
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            using (EditCustomer ec = new EditCustomer())
            {
                ListViewItem item = listView1.SelectedItems[i];
                string name = item.SubItems[0].Text;
                string id = item.SubItems[1].Text;
                ec.name_txt.Text = name.ToString();
                ec.id_txt.Text = id.ToString();

                ec.ShowDialog(this);
            }
        }

        //test to check customer writing to txt file
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = listView1.SelectedItems[i];
                if (File.ReadAllText("data.txt").Contains(item.SubItems[0].Text))
                {
                    MessageBox.Show("There is a match");
                }
            }
        }

        //tolistview
        private void button2_Click(object sender, EventArgs e)
        {
            _controller.ToListview(listView1, _controller);
        }

        //write to file
        private void button3_Click(object sender, EventArgs e)
        {
            _controller.WriteFile(listView1);
        }


        private void remove_btn_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[i];
            _controller.Remove(item.SubItems[0].Text);
            _controller.ToListview(listView1, _controller);
            _controller.WriteFile(listView1);
        }

        private void add_btn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("To add a user, type in the textbox and press add", add_btn);
        }

        private void customer_name_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("To add a user, type in the textbox and press add", customer_name);
        }

        private void edit_btn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("To edit a user, select a user from the list and press the edit button", edit_btn);
        }

        private void remove_btn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("To remove a user, select a user from the list and press the remove button", remove_btn);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            HomePage myForm = new HomePage();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();
        }
    }
}
