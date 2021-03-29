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
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using a3.Helper;
using Syncfusion.WinForms.DataGrid.Events;
using a3.Models;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace a3.Forms
{
    public partial class AllCustomer : Form1
    {
        Controller _controller = new Controller();
        bool radio;


        public AllCustomer()
        {
            InitializeComponent();
            this.sfDataGrid_cm.AllowSorting = true;
            this.sfDataGrid_cm.AllowEditing = false;
            this.sfDataGrid_cm.AllowDeleting = true;
            

            if (radioButton1.Checked == true)
            {
                radio = true;
            }
            else if (radioButton2.Checked == true)
            {
                radio = false;
            }
        }

        private void AllCustomer_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        public void UpdateForm()
        {
            Read();
            sfDataGrid_cm.DataSource = _controller.custList;
        }

        public void Read()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            _controller.custList = (List<Customer>)formatter.Deserialize(stream);
            SingletonData.setInstance((SingletonData)formatter.Deserialize(stream));
            stream.Close();
        }

        #region Customer forms
        private void cm_searchTxt_TextChanged(object sender, EventArgs e)
        {
            this.sfDataGrid_cm.SearchController.Search(this.cm_searchTxt.Text);
        }

        private void SetSelectedItem()
        {
           
            var recordIndex = this.sfDataGrid_cm.TableControl.ResolveToRecordIndex(1);
            this.sfDataGrid_cm.SelectedIndex = recordIndex;
        }


        private void SfDataGrid_cm_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.RowType == RowType.DefaultRow)
            {
                cm_idbox.Text = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Id").ToString();
                cm_phoneBox.Text = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Phone").ToString();
                cm_emailBox.Text = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Email").ToString();
                cm_nameBox.Text = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Name").ToString();
                var radio = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Staff").ToString();
                if (radio == "True")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (radio == "False")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
            else if (e.DataRow.RowType == RowType.HeaderRow)
            {
                var cellValue = e.DataColumn.GridColumn.HeaderText;
            }


        }

        #endregion


        #region New customer form
        private void newcust_comfirmBtn_Click(object sender, EventArgs e)
        {
            bool staff;
            if (newcust_staffTrue.Checked)
            {
                staff = true;
            }
            else
            {
                staff = false;
            }
            _controller.AddCustomer(newcust_nameBox.Text, newcust_emailBox.Text, Convert.ToInt32(newcust_phoneBox.Text), staff);
            _controller.WriteBinaryData();
            UpdateForm();
        }

        #endregion

        private void cm_updateBtn_Click(object sender, EventArgs e)
        {
            var orderInfo = this.sfDataGrid_cm.CurrentItem as Customer;
            orderInfo.Name = cm_nameBox.Text;
            orderInfo.Email = cm_emailBox.Text;
            orderInfo.Phone = Convert.ToInt32(cm_phoneBox.Text);
            orderInfo.Staff = radio;
            _controller.WriteBinaryData();
            UpdateForm();
        }

        private void sfDataGrid_cm_Click(object sender, EventArgs e)
        {

        }

        private void sfDataGrid_cm_CellDoubleClick(object sender, CellClickEventArgs e)
        {

        }

        private void cm_deleteBtn_Click(object sender, EventArgs e)
        {
            var orderInfo = this.sfDataGrid_cm.CurrentItem as Customer;
            _controller.Remove(orderInfo.Id);
            _controller.WriteBinaryData();
            UpdateForm();
        }


    }

}
