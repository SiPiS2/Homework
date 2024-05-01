using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoExOnline
{
    internal class Cat:Animal
    {
        public Cat(string name, int age, string description) : base(name, age, description)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Mew");
        }
        public override void ViewInfor()
        {

        }
    }
}
