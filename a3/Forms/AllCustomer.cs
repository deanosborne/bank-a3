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

namespace a3.Forms
{
    public partial class AllCustomer : Form1
    {
        Controller _controller = new Controller();


        public AllCustomer()
        {
            InitializeComponent();
            this.sfDataGrid_cm.AllowSorting = true;
        }

        private void AllCustomer_Load(object sender, EventArgs e)
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
            var rowIndex = this.sfDataGrid_cm.SearchController.CurrentRowColumnIndex.RowIndex;
            var recordIndex = this.sfDataGrid_cm.TableControl.ResolveToRecordIndex(rowIndex);
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
                string radio = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Staff").ToString();
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
        }

        #endregion
    }
}
