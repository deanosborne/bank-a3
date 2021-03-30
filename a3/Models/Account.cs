﻿using a3.Helper;
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
        private int c_id;
        private decimal a_fee;
        private decimal a_interest;
        private decimal a_balance;
        private List<Account> GetAccounts;

        public Account(string name, int id)
        {
            SingletonDataAccount.getInstance();
            this.Id = SingletonDataAccount.NextId;
            this.Name = name;
            this.CustomerId = id;
            this.Fee = 10.0m;
            this.Interest = 0.04m;
            this.Balance = 0;
        }

        public Account() { }

        public List<Account> _GetAccounts
        {
            get { return GetAccounts; }
            set { GetAccounts = value; }
        }

        public int Id
        {
            get { return a_id; }
            set { a_id = value; }
        }

        public string Name
        {
            get { return a_name; }
            set { a_name = value; }
        }

        public int CustomerId
        {
            get { return c_id; }
            set { c_id = value; }
        }
        public decimal Fee
        {
            get { return a_fee; }
            set { a_fee = value; }
        }
        public decimal Interest
        {
            get { return a_interest; }
            set { a_interest = value; }
        }

        public decimal Balance
        {
            get { return a_balance; }
            set { a_balance = value; }
        }
    }

    [Serializable]
    public class Transaction : Account
    {
        private int t_id;
        private decimal t_amount;

        public Transaction(decimal amount, int id)
        {
            SingletonDataTransaction.getInstance();
            this.TransactionId = SingletonDataAccount.NextId;
            this.Amount = amount;
        }

        public int TransactionId
        {
            get { return t_id; }
            set { t_id = value; }
        }

        public decimal Amount
        {
            get { return t_amount; }
            set { t_amount = value; }
        }
    }
}