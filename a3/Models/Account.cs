using a3.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a3.Models
{
    [Serializable]
    public class Account
    {
        
        private int a_id;
        private string a_name;
        private decimal a_balance;
        private Customer c_id;
        private decimal a_fee;
        private decimal a_interest;
        private List<Account> GetAccounts;

        public Account(string name, decimal balance, Customer id, decimal fee, decimal interest)
        {
            this.A_name = name;
            this.A_balance = balance;
            this.C_id = id;
            this.A_fee = fee;
            this.A_interest = interest;
            _GetAccounts = new List<Account>();
        }

        public Account() { }

        public List<Account> _GetAccounts
        {
            get { return GetAccounts; }
            set { GetAccounts = value; }
        }

        public string A_name
        {
            get { return a_name; }
            set { a_name = value; }
        }

        public decimal A_balance
        {
            get { return a_balance; }
            set { a_balance = value; }
        }

        public Customer C_id
        {
            get { return c_id; }
            set { c_id = value; }
        }
        public decimal A_fee
        {
            get { return a_fee; }
            set { a_fee = value; }
        }
        public decimal A_interest
        {
            get { return a_interest; }
            set { a_interest = value; }
        }


    }
}
