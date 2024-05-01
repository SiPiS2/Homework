using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class Dog:Animal
    {
        public Dog(string name, int age, string favoriteFood) : base(name, age, favoriteFood)
        {
            

        }
        public override void Run()
        {
            Console.WriteLine("DogRun");
        }
        public override void MakeSound()
        {
            
        }
        public override void Sleep()
        {
            
        }      
    }
}
