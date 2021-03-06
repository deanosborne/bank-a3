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

        /// <summary>
        /// Adds a new account
        /// </summary>
        /// <param name="name">Name to be added</param>
        /// <param name="id">Id to be added</param>
        /// <param name="fee">Fee to be added</param>
        public void AddAccount(string name, int id, decimal fee)
        {
            accList.Add(new Account(name, id, fee ));
        }
        /// <summary>
        /// Add a new customer
        /// </summary>
        /// <param name="name">Name to be added</param>
        /// <param name="email">Email to be added</param>
        /// <param name="phone">Phone number to be added</param>
        /// <param name="staff">Sets staff to true or false</param>
        public void AddCustomer(string name, string email, int phone, bool staff)
        {
            custList.Add(new Customer(name, email, phone, staff));
        }

        /// <summary>
        /// Find a customer by id from the list in Controller
        /// </summary>
        /// <param name="id">Id to be returned</param>
        /// <returns>Id if customer is found when compared else returns null</returns>
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

        /// <summary>
        /// Find an account by id from the list in Controller
        /// </summary>
        /// <param name="id">Id to be returned</param>
        /// <returns>Id if customer is found when compared else returns null</returns>
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

        /// <summary>
        /// Removes customer from cust list after comparing id
        /// </summary>
        /// <param name="id">Id to be returned</param>
        public void RemoveC(int id)
        {
            custList.Remove(RemoveCustomer(id));
        }

        /// <summary>
        /// Removes account from acc list after comparing id
        /// </summary>
        /// <param name="id">Id to be returned</param>
        public void RemoveA(int id)
        {
            accList.Remove(RemoveAccount(id));
        }

        /// <summary>
        /// Adds an amount to the balance. Throws exception if amount under 0
        /// </summary>
        /// <param name="amount">Amount to be added to balance</param>
        /// <param name="balance">Balance before amount added</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount, decimal balance)
        {
            if (amount <= 0)
            {
                throw new InsufficientFundsException("Deposit has failed for account: ");
            }
            balance += amount;

            return balance;
        }

        /// <summary>
        /// Subtracts an amount to the balance. Throws exception if amount > balance, charges defined fee
        /// </summary>
        /// <param name="amount">Amount to be subtracted to balance</param>
        /// <param name="balance">Balance before amount subtracted</param>
        /// <returns>New balance</returns>
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

        /// <summary>
        /// Calculate interest and add to balance
        /// </summary>
        /// <param name="balance">Balance before calulated and added interest</param>
        /// <param name="interest">Interest percentage to be calculated</param>
        /// <returns>New balance</returns>
        public decimal Interest(decimal balance, decimal interest)
        {
            //if (balance < 1000)
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

        /// <summary>
        /// Compare id in controller account list
        /// </summary>
        /// <param name="id">Id to be compared</param>
        /// <returns>Account details</returns>
        public Account GetAccount(int id)
        {
            Account account = accList.Find(p => p.Id == id);

            return account;
        }

        /// <summary>
        /// Compare id in controller customer list
        /// </summary>
        /// <param name="id">Id to be compared</param>
        /// <returns>Customer details</returns>
        public Customer GetCustomer(int id)
        {
            Customer customer = custList.Find(p => p.Id == id);

            return customer;
        }

        /// <summary>
        /// Transfer of customer funds from one account to another
        /// </summary>
        /// <param name="amount">Amount to be transferred</param>
        /// <param name="id1">To account</param>
        /// <param name="id2">From account</param>
        /// <returns>To and from account balances called by index</returns>
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
                Account fromAccount = GetAccount(id1);
                Account toAccount = GetAccount(id2);

                decimal[] balindex = new decimal[2];
                decimal balance1 = fromAccount.Balance -= amount;
                decimal balance2 = toAccount.Balance += amount;

                balindex[0] = balance1;
                balindex[1] = balance2;

                return balindex;
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

        public virtual string AccountInfo(string acctype, decimal balance)
        {
            string _accountinfo = acctype
                + "\r\nBalance: $"
                + balance
                + "\r\nInterest only calculated over $1000"
            + "\r\nInterest rate: 4%"
            + "\r\nFailed transaction fee: $10"+"\r\n\r\n";
            return _accountinfo;

        }
        public virtual string DepositInfo(decimal amount, string acctype, decimal balance)
        {
            string _deposit = acctype
                + "\r\nDeposit: $"
                + amount + "\r\nBalance: $"
                + balance + "\r\n\r\n";
            return _deposit;

        }

        public virtual string WithdrawInfo(decimal amount, string acctype, decimal balance)
        {
            string _withdraw = acctype
                + "\r\nWithdraw: $"
                + amount + "\r\nBalance: $"
                + balance + "\r\n\r\n";
            return _withdraw;

        }
        public virtual string InterestInfo(string acctype, decimal balance)
        {
            string _interest = acctype
                + "\r\nInterest added: $"
                + a.Interest + "\r\nBalance: $"
                + balance + "\r\n\r\n";
            return _interest;

        }

        public virtual string TransferInfo(string account1, string account2, int id1, int id2, decimal amount, decimal balance, decimal balance2)
        {
            string _transfer = "Transfer from: " + id1 + " " + account1
                + "\r\nTo: " + id2 + " " + account2
                + "\r\nAmount: " + amount
                + "\r\n" + account1 + " Balance: " + balance
                + "\r\n" + account2 + " Balance: " + balance2
                + "\r\n\r\n";
            return _transfer;

        }

        /// <summary>
        /// Writes Customer data to binary file, persists nextID
        /// </summary>
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

        /// <summary>
        /// Writes Account data to binary file, persists nextID
        /// </summary>
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

            //close the file
            stream.Close();

        }


    }
}
