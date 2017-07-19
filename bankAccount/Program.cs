using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closing = false;
            do
            {
                
                // Checking checking2 = new Checking();
                Savings savings1 = new Savings();
                // Checking checking1=new Checking(100000.00M);
                Checking checking1 = new Checking();
                Client viewInfo = new Client();
                // Client viewInfo1 = new Client("Henry Winkler", "1864 Fonz Rd. Alaska 93694", 57, 123 - 45 - 6789);
                Client ViewInfo1 = new Client();
                ViewInfo1.Name = "Henry Winkler";
                ViewInfo1.Address = "1864 Fonz Rd. Alaska 93694";
                ViewInfo1.Age = 57;
                ViewInfo1.SocialSecurity = "123-45-6789";
                checking1.AccountBalance = 1000000.00M;
                savings1.AccountBalance = 150.00M;
                checking1.AccountNumber = 543654765;
                savings1.AccountNumber = 987675654;


                //    string person = viewInfo1.Name;


                //menu
                Console.WriteLine("Welcome to My Bank! Please select a transaction:");
                Console.WriteLine("[1] : View Client Information");
                Console.WriteLine("[2] : View Account Balance");
                Console.WriteLine("[3] : Deposite Funds");
                Console.WriteLine("[4] : Withdraw Funds");
                Console.WriteLine("[5] : Exit");
                int input = int.Parse(Console.ReadLine());


                if (input == 1)
                {
                    viewInfo.PersonalInfo();
                    Console.WriteLine("Client Name: {0}\nClient Address: {1}\nClient Age: {2}\nClient Soc.Sec.#: {3}\nChecking Account Number: {4}\nSavings Account Number: {5} ", ViewInfo1.Name, ViewInfo1.Address, ViewInfo1.Age, ViewInfo1.SocialSecurity, checking1.AccountNumber, savings1.AccountNumber);
                }
                if (input == 2)
                {
                    Console.WriteLine("Which account would you like to access?");
                    Console.WriteLine("[a] : Checking");
                    Console.WriteLine("[b] : Savings");
                    string input1 = Console.ReadLine().ToLower();
                    if (input1 == "a")
                    {
                        Console.WriteLine("${0}", checking1.AccountBalance);

                    }
                    if (input1 == "b")
                    {
                        Console.WriteLine("${0}", savings1.AccountBalance);
                    }
                }
                if (input == 3)
                {
                    Console.WriteLine("Which account would you like to deposit funds in to?");
                    Console.WriteLine("[a] : Checking");
                    Console.WriteLine("[b] : Savings");
                    string input2 = Console.ReadLine().ToLower();
                    if (input2 == "a")
                    {

                        decimal total = checking1.DepositFunds(1000000.00M, 0M);

                        //  checking1.DepositFunds();
                        //  Console.WriteLine(newAccountDepositBalance);

                    }
                    if (input2 == "b")
                    {
                        savings1.DepositFunds(150.00M, 0M);
                    }

                }
                if (input == 4)
                {
                    Console.WriteLine("Which account would you like to withraw funds from?");
                    Console.WriteLine("[a] : Checking");
                    Console.WriteLine("[b] : Savings");
                    string input3 = Console.ReadLine().ToLower();
                    if (input3 == "a")
                    {
                        checking1.Withdraw(1000000.00M, 0M);
                    }
                    if (input3 == "b")
                    {
                        savings1.Withdraw(150.00M, 0M);
                        if (savings1.AccountBalance < 5.00M)
                        {
                            Console.WriteLine("Account balance cant be below $5.00!");
                        }
                    }

                }
                if (input == 5)
                {
                    Console.WriteLine("Thank you for choosing My Bank! Have a nice day!");
                    closing = true;
                    Environment.Exit(0);
                }
            }
            while (closing == false);


        }

    }
}
