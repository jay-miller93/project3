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
        private int socialSecurity;

        //properties
        public string Name { get; }
        public string Address { get; }
        public int Age { get; }
        public int SocialSecurity { get; }

        //constructors
        public Client()
        {

        }
        public Client(string name, string address, int age, int socialSecurity)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.socialSecurity = socialSecurity; 
        }



    }
}
