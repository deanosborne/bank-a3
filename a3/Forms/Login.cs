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
    public partial class Login : BlankForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Authenticate()
        {
            if (username_txt.Text == "admin" | password_txt.Text == "admin")
            {
                this.Hide();
                HomePage myForm = new HomePage();
                myForm.Closed += (s, args) => this.Close();
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password! hint: admin/admin");
            }
        }
        private void login_btn_Click(object sender, EventArgs e)
        {

            Authenticate();
        }

    }
}
