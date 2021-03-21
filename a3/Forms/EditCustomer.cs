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

namespace a3.Forms
{
    public partial class EditCustomer : Form1
    {
        Controller _controller = new Controller();
        Customer c = new Customer();
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = (Form3)this.Owner;

            int i = 0;
            ListViewItem item = f3.listView1.SelectedItems[i];
            item.SubItems[0].Text = name_txt.Text;
            item.SubItems[1].Text = id_txt.Text;

            this.Close();
            _controller.WriteFile(f3.listView1);
        }
    }
}
