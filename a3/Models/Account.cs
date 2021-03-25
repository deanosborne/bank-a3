using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a3.Models
{
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




        //    public void DepositMoney(int amount)
        //    {
        //        if (amount <= 0)
        //        {
        //            throw new InsufficientFundsException("Deposit has failed for account: ");
        //        }
        //        else
        //        {
        //            balance += amount;
        //        }

        //    }
        //    public void WithdrawMoney(int amount)
        //    {
        //        if (amount > Balance)
        //        {
        //            throw new InsufficientFundsException("Withdrawal has failed for account: ");
        //        }
        //        else
        //        {
        //            balance -= amount;
        //        }

        //    }

        //    public void CalculateInterest(int rate, int threshold)
        //    {
        //        if (balance < threshold)
        //        {
        //            throw new InsufficientBalanceException("Balance less than " + threshold + " for account: ");
        //        }
        //        else
        //        {
        //            InterestAmount = (Balance * rate) / 100;
        //            balance += interestamount;
        //        }
        //    }

        //    public class InsufficientFundsException : Exception
        //    {
        //        public InsufficientFundsException(string message ):base(message)
        //        {
        //        }
        //    }

        //    public class InsufficientBalanceException : Exception
        //    {
        //        public InsufficientBalanceException(string message) : base(message)
        //        {
        //        }
        //    }


        //    public virtual string AccountInfo(string acctype)
        //    {
        //        string _accountinfo = acctype
        //            + "\r\nBalance: $"
        //            + balance
        //            + "\r\nInterest only calculated over $1000"
        //        +"\r\nInterest rate: 4%"
        //        +"\r\nFailed transaction fee: $10";
        //        return _accountinfo;

        //    }
        //    public virtual string DepositInfo(decimal amount, string acctype)
        //    {
        //        string _deposit = acctype
        //            + "\r\nDeposit: $"
        //            + amount + "\r\nBalance: $"
        //            + balance + "\r\n";
        //        return _deposit; 

        //    }

        //    public virtual string WithdrawInfo(decimal amount, string acctype)
        //    {
        //        string _withdraw = acctype
        //            + "\r\nWithdraw: $"
        //            + amount + "\r\nBalance: $"
        //            + balance + "\r\n";
        //        return _withdraw;

        //    }
        //    public virtual string InterestInfo(string acctype)
        //    {
        //        string _interest = acctype
        //            + "\r\nInterest added: $"
        //            + interestamount + "\r\nBalance: $"
        //            + balance + "\r\n";
        //        return _interest;

        //    }

    }
}
