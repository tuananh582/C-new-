
using System;
namespace VirtualDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Stif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old ");
            dog.Play();
            dog.Eat();

        }
    }

}


