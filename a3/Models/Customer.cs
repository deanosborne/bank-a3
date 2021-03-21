using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Models
{
    public class Customer
    {
        private string name;
        private string customerID;
        private static int count = 1;

        public List<Customer> _customers = new List<Customer>();

        public Customer(string newName, string _customerid)
        {
            Name = newName;
            _customerid = "E000" + count;
            count++;
            customerID = _customerid;
        }

        public Customer(string newName)
        {
            Name = newName;
            customerID = "E000" + count;
            count++;
        }
        public Customer() { }

        public string Name { get => name; set => name = value; }
        public string _Cid { get => customerID; set => customerID = value; }



    }
}
