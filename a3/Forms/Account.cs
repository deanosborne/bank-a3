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
    public partial class Account : Form1
    {
        Omni o = new Omni();
        public Account()
        {
            InitializeComponent();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            o.Withdraw(Convert.ToInt32(numericUpDown1.Text));
            textBox1.Text = o.WithdrawInfo(Convert.ToInt32(numericUpDown1.Text), o.accounttype);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            o.Deposit(Convert.ToInt32(numericUpDown1.Text));
            textBox1.Text = o.DepositInfo(Convert.ToInt32(numericUpDown1.Text), o.accounttype);
        }

        private void Account_Load(object sender, EventArgs e)
        {
            textBox1.Text = o.AccountInfo(o.accounttype);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o.Interest();
            textBox1.Text = o.InterestInfo(o.accounttype);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage myForm = new HomePage();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();
        }
    }
}
