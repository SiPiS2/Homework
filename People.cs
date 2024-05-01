using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class People:IRunnable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public People(string name, int age, string address, string phoneNumber)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
        }
       public void Run()
        {
            Console.WriteLine("PeopleRun");
        }
        public void Study()
        {

        }
    }
}
