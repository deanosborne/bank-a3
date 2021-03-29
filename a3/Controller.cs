using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Reflection;
using a3.Forms;
using a3.Models;
using Syncfusion.WinForms.DataGrid;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using a3.Helper;

namespace a3
{
    public class Controller
    {
        Account _account = new Account();
        Customer c = new Customer();
        public List<Account> accList = new List<Account>();
        public List<Customer> custList = new List<Customer>();

        public Controller()
        {

        }

        public void AddAccount(string name, decimal balance, Customer id, decimal fee, decimal interest)
        {
            accList.Add(new Account(name, balance, id, fee, interest));
        }

        public void UpdateAccount()
        {

        }

        public void AddCustomer(string name, string email, int phone, bool staff)
        {
            custList.Add(new Customer(name, email, phone, staff));
        }
        public void EditCustomer()
        {

        }

        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, custList);
            formatter.Serialize(stream, SingletonData.getInstance());

            //close the file
            stream.Close();

        }


    }
}
