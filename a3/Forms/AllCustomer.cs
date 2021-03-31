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
using Syncfusion.Data;

namespace a3.Forms
{
    public partial class AllCustomer : Form1
    {
        Controller _controller = new Controller();
        Omni o = new Omni();
        Account a = new Account();

        public AllCustomer()
        {
            InitializeComponent();
            this.sfDataGrid_cm.AllowSorting = true;
            this.sfDataGrid_cm.AllowEditing = false;
            this.sfDataGrid_cm.AllowDeleting = true;
            this.sfDataGrid_ma.AllowSorting = true;
            this.sfDataGrid_ma.AllowEditing = false;
            this.sfDataGrid_ma.AllowDeleting = true;

            newacc_typeBox.DisplayMember = "Text";
            newacc_typeBox.ValueMember = "Value";
            newacc_typeBox.Items.Add(new { Text = "Omni", Value = "Omni" });
            newacc_typeBox.Items.Add(new { Text = "Free", Value = "Free" });
            newacc_typeBox.Items.Add(new { Text = "Lifestyle", Value = "Lifestyle" });

            at_transactiontypeCombo.DisplayMember = "Text";
            at_transactiontypeCombo.ValueMember = "Value";
            at_transactiontypeCombo.Items.Add(new { Text = "Withdraw", Value = "Withdraw" });
            at_transactiontypeCombo.Items.Add(new { Text = "Deposit", Value = "Deposit" });
            at_transactiontypeCombo.Items.Add(new { Text = "Add interest", Value = "Add interest" });
            at_transactiontypeCombo.Items.Add(new { Text = "Transfer", Value = "Transfer" });

            


        }

        private void AllCustomer_Load(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateFormAccount();
            //_controller.WriteBinaryData();
            //_controller.WriteBinaryDataAccount();
        }

        public void UpdateForm()
        {
            Read();
            sfDataGrid_cm.DataSource = _controller.custList;
        }

        public void UpdateFormAccount()
        {
            ReadAccount();
            var custInfo = this.sfDataGrid_cm.CurrentItem as Customer;

            if (this.sfDataGrid_cm.CurrentItem != null)
            {
                sfDataGrid_ma.DataSource = _controller.accList;
                sfDataGrid_ma.Columns["CustomerId"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = custInfo.Id });
                foreach (var v in _controller.accList)
                {
                    comboBox1.Items.Add(v.Id.ToString());
                }
            }
        }

        public void UpdateFormTransaction()
        {
            var accInfo = this.sfDataGrid_ma.CurrentItem as Account;
            at_idBox.Text = accInfo.Id.ToString();
            at_typeBox.Text = accInfo.Name.ToString();
            at_balanceBox.Text = accInfo.Balance.ToString();
        }

        public void Read()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            _controller.custList = (List<Customer>)formatter.Deserialize(stream);
            SingletonDataCustomer.setInstance((SingletonDataCustomer)formatter.Deserialize(stream));
            stream.Close();
        }

        //account
        public void ReadAccount()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("AccObjects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            _controller.accList = (List<Account>)formatter.Deserialize(stream);
            SingletonDataAccount.setInstance((SingletonDataAccount)formatter.Deserialize(stream));
            SingletonDataTransaction.setInstance((SingletonDataTransaction)formatter.Deserialize(stream));
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
                newacc_idBox.Text = this.sfDataGrid_cm.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Id").ToString();
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
            tabControl1.SelectedIndex = 0;
        }

        #endregion

        private void cm_updateBtn_Click(object sender, EventArgs e)
        {
            bool radio;
            var custInfo = this.sfDataGrid_cm.CurrentItem as Customer;
            custInfo.Name = cm_nameBox.Text;
            custInfo.Email = cm_emailBox.Text;
            custInfo.Phone = Convert.ToInt32(cm_phoneBox.Text);

            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                custInfo.Staff = true;
            }
            else if (radioButton2.Checked == true && radioButton1.Checked == false)
            {
                custInfo.Staff = false;
            }

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
            var custInfo = this.sfDataGrid_cm.CurrentItem as Customer;
            _controller.RemoveC(custInfo.Id);
            _controller.WriteBinaryData();
            UpdateForm();
        }

        #region new account

        private void newacc_updateBtn_Click(object sender, EventArgs e)
        {
            string selected = this.newacc_typeBox.GetItemText(this.newacc_typeBox.SelectedItem);
            var custInfo = this.sfDataGrid_cm.CurrentItem as Customer;
            var thiscustomer = _controller.GetCustomer(custInfo.Id);
            decimal fee = a.Fee / 2;

            if (thiscustomer.Staff == true)
            {
                _controller.AddAccount(selected, custInfo.Id, fee);
            }
            else
            {
                _controller.AddAccount(selected, custInfo.Id, a.Fee);
            }

            _controller.WriteBinaryDataAccount();
            UpdateFormAccount();
            tabControl1.SelectedIndex = 1;
        }

        private void newacc_typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newacc_typeBox.SelectedIndex == 0)
            {
                newacc_feeBox.Text = String.Format("{0:C}", o.fee);
                newacc_interestBox.Text = String.Format("{0:P2}.", o.interest);
            }
        }

        private void newacc_typeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = newacc_typeBox.SelectedValue.ToString();
        }

        #endregion

        private void cm_toaccountBtn_Click(object sender, EventArgs e)
        {
            UpdateFormAccount();
            tabControl1.SelectedIndex = 1;
        }

        private void SfDataGrid_ma_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataRow.RowType == RowType.DefaultRow)
            {
                string selected = this.newacc_typeBox.GetItemText(this.newacc_typeBox.SelectedItem);
                var custInfo = this.sfDataGrid_cm.CurrentItem as Customer;
                ma_nameBox.Text = this.sfDataGrid_ma.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Id").ToString();
                ma_typeBox.Text = this.sfDataGrid_ma.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Name").ToString();
                ma_interestBox.Text = this.sfDataGrid_ma.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Interest").ToString();
                ma_feeBox.Text = this.sfDataGrid_ma.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Fee").ToString();
                ma_balBox.Text = this.sfDataGrid_ma.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Balance").ToString();
                var radio = custInfo.Staff.ToString();
                if (radio == "True")
                {
                    radioButton6.Checked = true;
                    radioButton5.Checked = false;
                }
                else if (radio == "False")
                {
                    radioButton6.Checked = false;
                    radioButton5.Checked = true;
                }
            }
            else if (e.DataRow.RowType == RowType.HeaderRow)
            {
                var cellValue = e.DataColumn.GridColumn.HeaderText;
            }


        }

        #region Transactions

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2 && this.sfDataGrid_ma.CurrentItem != null)
            {
                var accInfo = this.sfDataGrid_ma.CurrentItem as Account;
                at_idBox.Text = accInfo.Id.ToString();
                at_typeBox.Text = accInfo.Name.ToString();
                at_balanceBox.Text = accInfo.Balance.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void at_backBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ma_deleteBtn_Click(object sender, EventArgs e)
        {
            var accInfo = this.sfDataGrid_ma.CurrentItem as Account;
            _controller.RemoveA(accInfo.Id);
            _controller.WriteBinaryDataAccount();
            UpdateFormAccount();
        }



        private void at_updateBtn_Click(object sender, EventArgs e)
        {
            var accInfo = this.sfDataGrid_ma.CurrentItem as Account;
            var idd = accInfo.Id;
            //withdraw
            if (at_transactiontypeCombo.SelectedIndex == 0)
            {
                decimal w = _controller.Withdraw(Convert.ToDecimal(at_amountBox.Text), Convert.ToDecimal(accInfo.Balance));
                at_balanceBox.Text = w.ToString();
                accInfo.Balance = Convert.ToDecimal(at_balanceBox.Text);
                this.sfDataGrid_cm.SearchController.Search(at_idBox.Text);
                SetSelectedItem();
                _controller.WriteBinaryDataAccount();
            }

            //deposit
            if (at_transactiontypeCombo.SelectedIndex == 1)
            {
                decimal d = _controller.Deposit(Convert.ToDecimal(at_amountBox.Text), Convert.ToDecimal(accInfo.Balance));

                at_balanceBox.Text = d.ToString();
                accInfo.Balance = Convert.ToDecimal(at_balanceBox.Text);
                this.sfDataGrid_cm.SearchController.Search(at_idBox.Text);
                SetSelectedItem();
                _controller.WriteBinaryDataAccount();
            }
            //interest
            if (at_transactiontypeCombo.SelectedIndex == 2)
            {
                decimal i = _controller.Interest(Convert.ToDecimal(accInfo.Balance), Convert.ToDecimal(accInfo.Interest));

                at_balanceBox.Text = i.ToString("0.##");
                accInfo.Balance = Convert.ToDecimal(at_balanceBox.Text);
                this.sfDataGrid_cm.SearchController.Search(at_idBox.Text);
                SetSelectedItem();
                _controller.WriteBinaryDataAccount();
            }
            //transfer
            if (at_transactiontypeCombo.SelectedIndex == 3)
            {
                
                decimal[] d = _controller.Transfer(Convert.ToDecimal(at_amountBox.Text), Convert.ToInt32(at_idBox.Text), Convert.ToInt32(comboBox1.SelectedItem));
                var fromaccount = _controller.GetAccount(Convert.ToInt32(at_idBox.Text));
                var toaccount = _controller.GetAccount(Convert.ToInt32(comboBox1.SelectedItem));

                fromaccount.Balance = d[0];
                toaccount.Balance = d[1];

                _controller.WriteBinaryDataAccount();
                UpdateFormAccount();
                at_balanceBox.Text = fromaccount.Balance.ToString();
                at_balancebox2.Text = toaccount.Balance.ToString();
            }
        }

        private void at_transactiontypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (at_transactiontypeCombo.SelectedIndex == 3)
            {
                at_balancebox2.Visible = true;
                label27.Visible = true;
                outputaccLabel.Visible = true;
                comboBox1.Visible = true;

            }
            else
            {
                at_balancebox2.Visible = false;
                label27.Visible = false;
                outputaccLabel.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var toaccount = _controller.GetAccount(Convert.ToInt32(comboBox1.SelectedItem));
            at_balancebox2.Text = toaccount.Balance.ToString();
        }
    }

}
