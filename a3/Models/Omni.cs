using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a3.Models
{
    public class Omni : AccountM
    {
        public Omni()
        {
            this.accounttype = "Omni";
            this.fee = 10;
            this.interestthreshold = 1000;
            this.interestrate = 4;
        }
        public void Deposit(int amount)
        {
            try
            {
                DepositMoney(amount);
            }
            catch (InsufficientFundsException f)
            {
                MessageBox.Show(f.Message + accounttype);
            }
        }

        public void Withdraw(int amount)
        {
            try
            {
                WithdrawMoney(amount);
            }
            catch (InsufficientFundsException f)
            {
                MessageBox.Show(f.Message + accounttype + "\r\nYou have been charged $" + fee);
                balance -= fee;
            }

        }

        public void Interest()
        {
            try
            {
                CalculateInterest(interestrate, interestthreshold);
            }
            catch (InsufficientBalanceException f)
            {
                MessageBox.Show(f.Message + accounttype);
            }

        }

        public override string AccountInfo(string AccountType)
        {
            return base.AccountInfo(AccountType);
        }

        public override string DepositInfo(decimal amount, string AccountType)
        {
            return base.DepositInfo(amount, AccountType);
        }
        public override string WithdrawInfo(decimal amount, string AccountType)
        {
            return base.WithdrawInfo(amount, AccountType);
        }

        public override string InterestInfo(string AccountType)
        {
            return base.InterestInfo(AccountType);
        }
    }
}
