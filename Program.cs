using Microsoft.VisualBasic;

namespace DoExOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Tiger", 3, "No Information here");
            Console.WriteLine($"Name: {tiger.Name}, Age: {tiger.Age}, Description: {tiger.Description}");
            tiger.MakeSound();
            Dog dog = new Dog("Dog", 1, "No Information here");
            Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Description: {dog.Description}");
            dog.MakeSound();
            Cat cat = new Cat("Cat", 2, "No Information here");
            Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}, Description: {cat.Description}");
            tiger.MakeSound();
        }


    }
}
