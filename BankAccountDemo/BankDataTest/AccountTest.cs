using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountDemo
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod()]
        public void DepositeAmountPositiveTest()
        {
            //arrange
            Account acct = new Account(100);
            decimal amount = 30;
            decimal expectedBalance = 130;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            //act
            actualResult = acct.Deposit(amount);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void DepositeAmountNegativeTest()
        {
            //arrange
            Account acct = new Account(100);
            decimal amount = -30;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            //act
            actualResult = acct.Deposit(amount);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void DepositeAmountZeroTest()
        {
            //arrange
            Account acct = new Account(100);
            decimal amount = 0;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            //act
            actualResult = acct.Deposit(amount);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void WithdrawPositiveAmountTest()
        {
            //arrange
            Account acct = new Account(100);
            decimal amount = 30;
            decimal expectedBalance = 70;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            //act
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void WithdrawPositiveNSFTest()
        {
            //arrange
            Account acct = new Account(100);
            decimal amount = 130;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            //act
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void ConstructorPositiveBalance()
        {
            //arrange
            decimal initBalance = 50;
            decimal expectedBalance = 50;
            decimal actualBalance;

            //act
            Account acct;
            acct = new Account(initBalance);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        [TestMethod()]
        public void ConstructorNegativeBalance()
        {
            //arrange
            decimal initBalance = -50;
            decimal expectedBalance = 0;
            decimal actualBalance;

            //act
            Account acct;
            acct = new Account(initBalance);
            actualBalance = acct.Balance;

            //assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
