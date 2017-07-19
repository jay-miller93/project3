using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Checking : Account
    {
        //fields
        protected int accountNumber;
        protected decimal accountBalance;

        //properties
        public decimal AccountBalance { get; set; }

        //constructor
        public Checking()
        {

        }
        public Checking(decimal accountBalance)
        {
            this.accountBalance = accountBalance;
        }
        public override decimal GetAccountBalance()
        {

            return accountBalance;

        }


    }
}
