using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal abstract class Animal:IRunnable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavoriteFood { get; set; }
        public abstract void Run();
        public abstract void Sleep();
        public abstract void MakeSound();

        public Animal(string name, int age, string favoriteFood)
        {
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;
        }
        
    }
}
