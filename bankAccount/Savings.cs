using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Savings : Account
    {
        //fields
        protected int accountNumber = 432654876;
        protected decimal accountBalance;

        public int AccountNumber { get; set; }


        //constuctor
        public Savings()
        {

        }
        public override decimal GetAccountBalance()
        {

            return accountBalance;

        }
    }
}
