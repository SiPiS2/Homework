using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class Car:IRunnable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Car(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;

        }

        public void Run()
        {
            Console.WriteLine("CarRun");
        }

        public void Rest()
        {

        }
    }
}
