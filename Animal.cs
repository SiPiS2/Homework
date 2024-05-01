using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoExOnline
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age {  get; set; }
        public abstract void ViewInfor();
        public abstract void MakeSound();
         public Animal(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public Animal()
        {
            Name = "Unknown";
            Age = 0;
            Description = "No description available";
        }

        // Constructor với 1 tham số (Tên)
        public Animal(string name)
        {
            Name = name;
            Age = 0;
            Description = "No description available";
        }

        // Constructor với 2 tham số (Tên, Tuổi)
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            Description = "No description available";
        }

        // Constructor với 3 tham số (Tên, Tuổi, Mô tả)
        public Animal(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
    }
}
