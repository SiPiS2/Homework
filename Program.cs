using System.Collections.Generic;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRunnable> runnables = new List<IRunnable>
           {
               new People("Alice", 20, "california", "074217547"),
            new Car("Ford", 3, "Black"),
            new Dog("Dog", 4, "DogFood"),
            new Cat("Cat", 2, "CatFood"),
        };
            foreach (var runnable in runnables)
            {
                runnable.Run();
            }
        }

    } 
}
           
                
        

            
        
 
