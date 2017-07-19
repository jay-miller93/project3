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
        protected decimal accountBalance = 1000000.00M;
        decimal newAccountDepositBalance;
        decimal deposit;
        decimal withdraw;
        //protected string savings;
        //protected string checking;
      
            //properties
        public int AccountNumber { get; }
        public decimal CheckingBalance { get; set; }
        public decimal SavingsBalance { get; set; }
        public decimal AccountBalance { get; set; }
       // public decimal Deposit { get; set; }
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
        public Account(decimal accountBalance)
        {
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

        public virtual decimal DepositFunds(decimal accountBalance, decimal deposit)
        {
            Console.WriteLine("How much would you like to deposit?");
            deposit = decimal.Parse(Console.ReadLine());
            newAccountDepositBalance = accountBalance + deposit;
            Console.WriteLine("Your new account balance is: $" + newAccountDepositBalance );
            return newAccountDepositBalance;
        }

        public virtual decimal Withdraw(decimal accountBalance, decimal withdraw)
        {
            Console.WriteLine("How much would you like to withdraw?");
            withdraw = decimal.Parse(Console.ReadLine());
            decimal newAccountWithdrawBalance = accountBalance - withdraw;
            Console.WriteLine("Your new account balance is: $" + newAccountWithdrawBalance);
            return newAccountWithdrawBalance;
        }

    }
}
