using Microsoft.VisualStudio.TestTools.UnitTesting;
using a3;
using a3.Forms;
using a3.Models;
using System;

namespace AccountTests
{
    [TestClass]
    public class AccountUnitTest
    {
        Omni o = new Omni();
        //Withdraw tests
        [TestMethod]
        public void Withdraw_Works_Amt_1()
        {
            int amount = 1;
            int balance = o.balance = 1;
            o.WithdrawMoney(amount);
            int expected = balance - amount;
            int actual = 0;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Withdraw_Works_Amt_624()
        {
            int amount = 624;
            int balance = o.balance = 999;
            o.WithdrawMoney(amount);
            int expected = balance - amount;
            int actual = 375;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Withdraw_Works_Amt_2134()
        {
            int amount = 2134;
            int balance = o.balance = 19823;
            o.WithdrawMoney(amount);
            int expected = balance - amount;
            int actual = 17689;

            Assert.AreEqual(expected, actual);
        }
        [ExpectedException(typeof(AccountM.InsufficientFundsException))]
        [TestMethod]
        public void Withdraw_Fails_Negative_1()
        {
            int amount = 1;
            int balance = o.balance = 0;
            o.WithdrawMoney(amount);
        }

        [ExpectedException(typeof(AccountM.InsufficientFundsException))]
        [TestMethod]
        public void Withdraw_Fails_Negative_999()
        {
            int amount = 999;
            int balance = o.balance = 235;
            o.WithdrawMoney(amount);
        }

        [ExpectedException(typeof(AccountM.InsufficientFundsException))]
        [TestMethod]
        public void Withdraw_Fails_Negative_5678()
        {
            int amount = 5678;
            int balance = o.balance = 3122;
            o.WithdrawMoney(amount);
        }

        //Interest tests
        [TestMethod]
        public void Interest_Works_Bal_1000()
        {
            int balance = o.balance = 1000;
            o.CalculateInterest(4, 1000);
            int expected = balance + (balance * 4) / 100;
            int actual = 1040;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Interest_Works_Bal_2996()
        {
            int balance = o.balance = 2996;
            int rate = 4;
            int threshold = 1000;
            o.CalculateInterest(rate, threshold);
            int expected = balance + (balance * rate) / 100;
            int actual = 3115;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Interest_Works_Bal_3561()
        {
            int balance = o.balance = 3561;
            int rate = 4;
            int threshold = 1000;
            o.CalculateInterest(rate, threshold);
            int expected = balance + (balance * rate) / 100;
            int actual = 3703;

            Assert.AreEqual(expected, actual);
        }
        [ExpectedException(typeof(AccountM.InsufficientBalanceException))]
        [TestMethod]
        public void Interest_Fails_Exception_Bal_92()
        {
            int balance = o.balance = 92;
            o.CalculateInterest(4, 1000);
        }

        [ExpectedException(typeof(AccountM.InsufficientBalanceException))]
        [TestMethod]
        public void Interest_Fails_Exception_Bal_998()
        {
            int balance = o.balance = 998;
            o.CalculateInterest(4, 1000);
        }

        [ExpectedException(typeof(AccountM.InsufficientBalanceException))]
        [TestMethod]
        public void Interest_Fails_Exception_Bal_567()
        {
            int balance = o.balance = 567;
            o.CalculateInterest(4, 1000);
        }

        //Deposit tests
        [TestMethod]
        public void Deposit_Works_Bal_92()
        {
            int amount = 4;
            int balance = o.balance = 92;
            o.DepositMoney(amount);
            int expected = balance + amount;
            int actual = 96;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Deposit_Works_Bal_223()
        {
            int amount = 356;
            int balance = o.balance = 223;
            o.DepositMoney(amount);
            int expected = balance + amount;
            int actual = 579;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Deposit_Works_Bal_1456()
        {
            int amount = 3567;
            int balance = o.balance = 1456;
            o.DepositMoney(amount);
            int expected = balance + amount;
            int actual = 5023;

            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(AccountM.InsufficientFundsException))]
        [TestMethod]
        public void Deposit_Fails_Negative_5678()
        {
            int amount = -5678;
            int balance = o.balance = 3122;
            o.DepositMoney(amount);
        }

        [ExpectedException(typeof(AccountM.InsufficientFundsException))]
        [TestMethod]
        public void Deposit_Fails_Negative_235()
        {
            int amount = -235;
            int balance = o.balance = 3122;
            o.DepositMoney(amount);
        }

        [ExpectedException(typeof(AccountM.InsufficientFundsException))]
        [TestMethod]
        public void Deposit_Fails_Negative_0()
        {
            int amount = 0;
            int balance = o.balance = 3122;
            o.DepositMoney(amount);
        }

    }
}
