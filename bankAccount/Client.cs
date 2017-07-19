using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Client
    {
        //fields
        private string name;
        protected string address;
        private int age;
        private string socialSecurity;

        //properties
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string SocialSecurity { get; set; }

        //constructors
        public Client()
        {

        }
        public Client(string name, string address, int age, string socialSecurity)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.socialSecurity = socialSecurity; 
        }

        //method
        public void PersonalInfo()
        {
            Console.WriteLine("Your Information:");
        }

    }
}
