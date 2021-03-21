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


namespace a3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your administrator to change your password", "Oops", MessageBoxButtons.OK);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myForm = new Form2();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
