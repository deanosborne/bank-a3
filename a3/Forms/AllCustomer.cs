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

namespace a3.Forms
{
    public partial class AllCustomer : Form1
    {
        Controller _controller = new Controller();
        public AllCustomer()
        {
            InitializeComponent();
        }

        private void AllCustomer_Load(object sender, EventArgs e)
        {
            sfDataGrid_cm.DataSource = _controller.custList;
            //_controller.Display(listView1, _controller);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void cm_updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
