using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Models
{
    [Serializable]
    public class Lifestyle : Account, Ihasfee, Ihasinterest, Ihasname
    {
        public decimal fee { get => Fee(); set => Fee(); }
        public decimal interest { get => Interest(); set => Interest(); }
        public string name { get => Name(); set => Name(); }
        public decimal Fee()
        {
            return 10.00m;
        }

        public decimal Interest()
        {
            return 0.04m;
        }

        public string Name()
        {
            return "Lifestyle";
        }
        public Lifestyle()
        {

        }
        //public void Deposit(int amount)
        //{
        //    try
        //    {
        //        DepositMoney(amount);
        //    }
        //    catch (InsufficientFundsException f)
        //    {
        //        MessageBox.Show(f.Message + accounttype);
        //    }
        //}

        //public void Withdraw(int amount)
        //{
        //    try
        //    {
        //        WithdrawMoney(amount);
        //    }
        //    catch (InsufficientFundsException f)
        //    {
        //        MessageBox.Show(f.Message + accounttype + "\r\nYou have been charged $" + fee);
        //        balance -= fee;
        //    }

        //}

        //public void Interest()
        //{
        //    try
        //    {
        //        CalculateInterest(interestrate, interestthreshold);
        //    }
        //    catch (InsufficientBalanceException f)
        //    {
        //        MessageBox.Show(f.Message + accounttype);
        //    }

        //}

        //public override string AccountInfo(string AccountType)
        //{
        //    return base.AccountInfo(AccountType);
        //}

        //public override string DepositInfo(decimal amount, string AccountType)
        //{
        //    return base.DepositInfo(amount, AccountType);
        //}
        //public override string WithdrawInfo(decimal amount, string AccountType)
        //{
        //    return base.WithdrawInfo(amount, AccountType);
        //}

        //public override string InterestInfo(string AccountType)
        //{
        //    return base.InterestInfo(AccountType);
        //}
    }
}
