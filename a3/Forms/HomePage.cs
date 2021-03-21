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
            Form3 myForm = new Form3();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account myForm = new Account();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();
        }
    }
}
