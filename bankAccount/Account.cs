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

        //properties
        public int AccountNumber { get; }
        public decimal CheckingBalance { get; }
        public decimal SavingsBalance { get; }

        //constructors
        public Account()
        {
             
        }
        public Account(int accountNumber, decimal checkingBalance, decimal savingsBalance)
        {
            this.accountNumber = accountNumber;
            this.checkingBalance = checkingBalance;
            this.savingsBalance = savingsBalance;
        }
       
        //method
        public virtual void Withdrawl()
    }
}
