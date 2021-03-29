using a3.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Models
{
    [Serializable]
    public class Customer
    {
 
        Account acc;
        private int c_id;
        private string c_name;
        private string c_email;
        private int c_phone;
        private bool c_staff;
        //List<Account> c_accounts = new List<Account>();


        public Customer() { }

        public Customer(string name, string email, int phone, bool staff)
        {
            SingletonData.getInstance();
            this.Id = SingletonData.NextId;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Staff = staff;
            //GetAccounts = new List<Account>();
        }

        public int Id
        {
            get { return c_id; }
            set { c_id = value; }
        }

        public string Name
        {
            get { return c_name; }
            set { c_name = value; }
        }

        public string Email
        {
            get { return c_email; }
            set { c_email = value; }
        }
        public int Phone
        {
            get { return c_phone; }
            set { c_phone = value; }
        }
        public bool Staff
        {
            get { return c_staff; }
            set { c_staff = value; }
        }

        //public List<Account> GetAccounts
        //{
        //    get { return c_accounts; }
        //    set { c_accounts = acc._GetAccounts; }
        //}

    }

    public class Staff : Customer, Ihasfee
    {
        decimal fee = 10.00m;
        public decimal Fee()
        {
            return fee / 2;
        }
    }
}
