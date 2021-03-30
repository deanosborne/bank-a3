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
        Account a = new Account();
        Customer c = new Customer();
        public List<Account> accList = new List<Account>();
        public List<Customer> custList = new List<Customer>();

        public Controller()
        {

        }

        public void AddAccount(string name, int id)
        {
            accList.Add(new Account(name, id ));
        }

        public void EditAccount()
        {

        }

        public void AddCustomer(string name, string email, int phone, bool staff)
        {
            custList.Add(new Customer(name, email, phone, staff));
        }
        public void EditCustomer()
        {

        }

        public Customer RemoveCustomer(int id)
        {
            foreach (Customer c in custList)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public Account RemoveAccount(int id)
        {
            foreach (Account a in accList)
            {
                if (a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }
        public void RemoveC(int id)
        {
            custList.Remove(RemoveCustomer(id));
        }

        public void RemoveA(int id)
        {
            accList.Remove(RemoveAccount(id));
        }

        public decimal Deposit(decimal amount, decimal balance)
        {
            if (amount <= 0)
            {
                throw new InsufficientFundsException("Deposit has failed for account: ");
            }
            balance += amount;

            return balance;
        }

        public decimal Withdraw(decimal amount, decimal balance)
        {
            if (amount > balance)
            {
                balance -= 10;
                throw new InsufficientFundsException("Withdrawal has failed for account");
            }
            else
            {
                balance -= amount;

                return balance;
            }
        }

        public decimal Interest(decimal balance, decimal interest)
        {
            //if (a.Balance < 1000)
            //{
            //    throw new InsufficientBalanceException("Balance less than " + 1000 + " for account");
            //}
            //else
            //{
            decimal interesta = (balance * interest);
            balance += interesta;

                return balance;
            //}
        }
        public Account GetAccount(int ownerId)
        {
            Account account = accList.Where(x => x.Id == ownerId).FirstOrDefault();

            if (account == null)
            {
                throw new ApplicationException("no account exists with that id");
            }

            return account;
        }
        public decimal[] Transfer(decimal amount, int id1, int id2)
        {
            if (amount <= 0)
            {
                throw new ApplicationException("transfer amount must be positive");
            }
            else if (amount == 0)
            {
                throw new ApplicationException("invalid transfer amount");
            }
            else if (id1 == id2)
            {
                throw new ApplicationException("same account");
            }
            else
            {
                Account fromAccount = accList.Find(p => p.Id == id1);
                Account toAccount = accList.Find(p => p.Id == id2);

                decimal[] rect = new decimal[2];
                decimal balance1 = fromAccount.Balance -= amount;
                decimal balance2 = toAccount.Balance += amount;

                rect[0] = balance1;
                rect[1] = balance2;

                return rect;
            }
        }

        public class InsufficientFundsException : Exception
        {
            public InsufficientFundsException(string message) : base(message)
            {
            }
        }

        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException(string message) : base(message)
            {
            }
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
            formatter.Serialize(stream, SingletonDataCustomer.getInstance());

            //close the file
            stream.Close();

        }

        public void WriteBinaryDataAccount()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("AccObjects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, accList);
            formatter.Serialize(stream, SingletonDataAccount.getInstance());
            formatter.Serialize(stream, SingletonDataTransaction.getInstance());

            //close the file
            stream.Close();

        }


    }
}
