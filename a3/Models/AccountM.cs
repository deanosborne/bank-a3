using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a3.Models
{
    public abstract class AccountM
    {
        private int Balance;
        private int InterestAmount;
        private string AccountType;
        private int Fee;
        private int InterestThreshold = 1000;
        private int InterestRate = 4;

        public int balance { get => Balance; set => Balance = value; }
        public int interestamount { get => InterestAmount; set => InterestAmount = value; }
        public string accounttype { get => AccountType; set => AccountType = value; }
        public int interestthreshold { get => InterestThreshold; set => InterestThreshold = value; }
        public int fee { get => Fee; set => Fee = value; }
        public int interestrate { get => InterestRate; set => InterestRate = value; }

        public void DepositMoney(int amount)
        {
            if (amount <= 0)
            {
                throw new InsufficientFundsException("Deposit has failed for account: ");
            }
            else
            {
                balance += amount;
            }

        }
        public void WithdrawMoney(int amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException("Withdrawal has failed for account: ");
            }
            else
            {
                balance -= amount;
            }

        }

        public void CalculateInterest(int rate, int threshold)
        {
            if (balance < threshold)
            {
                throw new InsufficientBalanceException("Balance less than " + threshold + " for account: ");
            }
            else
            {
                InterestAmount = (Balance * rate) / 100;
                balance += interestamount;
            }
        }

        public class InsufficientFundsException : Exception
        {
            public InsufficientFundsException(string message ):base(message)
            {
            }
        }

        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException(string message) : base(message)
            {
            }
        }


        public virtual string AccountInfo(string acctype)
        {
            string _accountinfo = acctype
                + "\r\nBalance: $"
                + balance
                + "\r\nInterest only calculated over $1000"
            +"\r\nInterest rate: 4%"
            +"\r\nFailed transaction fee: $10";
            return _accountinfo;

        }
        public virtual string DepositInfo(decimal amount, string acctype)
        {
            string _deposit = acctype
                + "\r\nDeposit: $"
                + amount + "\r\nBalance: $"
                + balance + "\r\n";
            return _deposit; 

        }

        public virtual string WithdrawInfo(decimal amount, string acctype)
        {
            string _withdraw = acctype
                + "\r\nWithdraw: $"
                + amount + "\r\nBalance: $"
                + balance + "\r\n";
            return _withdraw;

        }
        public virtual string InterestInfo(string acctype)
        {
            string _interest = acctype
                + "\r\nInterest added: $"
                + interestamount + "\r\nBalance: $"
                + balance + "\r\n";
            return _interest;

        }

    }
}
