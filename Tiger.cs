using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoExOnline
{
    internal class Tiger:Animal
    {
        public Tiger(string name,int age,string description) : base(name, age, description)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
        public override void ViewInfor()
        {
            
        }
    }
}
