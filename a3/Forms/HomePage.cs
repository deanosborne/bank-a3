using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a3.Forms;

namespace a3.Forms
{
    public partial class HomePage : Form1
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCustomer myForm = new AllCustomer();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
