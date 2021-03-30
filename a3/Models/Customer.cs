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
        private int c_id;
        private string c_name;
        private int c_phone;
        private bool c_staff;
        private string c_email;


        public Customer() { }

        public Customer(string name, string email, int phone, bool staff)
        {
            SingletonDataCustomer.getInstance();
            this.Id = SingletonDataCustomer.NextId;
            this.Name = name;
            
            this.Phone = phone;
            this.Staff = staff;
            this.Email = email;
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

        public string Email
        {
            get { return c_email; }
            set { c_email = value; }
        }

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
