using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo
{
    public class Account
    {
        //private data
        private static int counter = 100; //one copy shared between all class objects

        #region public properties
        public int AccNo { get; }
        public decimal Balance { get; set; }
        #endregion

        #region constructor
        public Account(decimal balance = 0)
        {
            AccNo = counter;
            counter++;
            if(balance < 0)
            {
                Balance = 0;
            }
            else
            {
                Balance = balance;
            }
        }
        /// <summary>
        /// Deposit amount of money into the account
        /// if the amount is negative, don't deposit
        /// </summary>
        /// <param name="amount"> amount to deposit</param>
        /// <returns></returns>
        public bool Deposit(decimal amount)
        {
            bool result = true;
            if (amount < 0)
            {
                result = false;
            }
            else
            {
                Balance += amount;
            }
            return result;
        }
        /// <summary>
        /// Withdraw amount of money into the account
        /// </summary>
        /// <param name="amount"> amount to withdraw</param>
        /// <returns></returns>
        public bool Withdraw(decimal amount)
        {
            bool result = true;
            if (amount < 0 || amount > Balance)
            {
                result = false;
            }
            else
            {
                Balance -= amount;
            }

            return result;
        }
        #endregion
    }
}
