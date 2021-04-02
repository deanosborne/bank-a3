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
using a3.Models;

namespace a3.Forms
{
    public partial class HomePage : Form1
    {
        Controller _controller = new Controller();
        AllCustomer _ac = new AllCustomer();

        public HomePage()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCustomer myForm = new AllCustomer();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }
    }
}
