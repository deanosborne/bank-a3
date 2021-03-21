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

            _controller.Display(listView1, _controller);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
