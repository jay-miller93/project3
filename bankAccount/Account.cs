using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Account//base class
    {
        //fields
        protected int accountNumber;
        protected decimal checkingBalance;
        protected decimal savingsBalance;
        protected decimal accountBalance;
        decimal deposit;
        decimal withdraw;
        //protected string savings;
        //protected string checking;
      
            //properties
        public int AccountNumber { get; }
        public decimal CheckingBalance { get; set; }
        public decimal SavingsBalance { get; set; }
        public decimal AccountBalance { get; set; }
        //public string Savings { get; set; }
        //public string Checking { get; set; }
        
            //constructors
        public Account()
        {
             
        }
        public Account(int accountNumber, decimal checkingBalance, decimal savingsBalance, decimal accountBalance)
        {
            this.accountNumber = accountNumber;
            this.checkingBalance = checkingBalance;
            this.savingsBalance = savingsBalance;
            this.accountBalance = accountBalance;
        }
        //public Account(string savings, string checking)
        //{
        //    //this.savings = savings;
        //    //this.checking = checking;

        //}

        public virtual decimal GetAccountBalance()
        {
            return accountBalance;

        }

        //public void GetAccountBalance()
        //{
          
        //}

        public virtual decimal Deposit()
        {

            decimal newAccountDepositBalance = accountBalance + deposit;
            return newAccountDepositBalance;
        }

        public virtual decimal Withdraw()
        {
            decimal newAccountWithdrawBalance = accountBalance - withdraw;
            return newAccountWithdrawBalance;
        }

    }
}
