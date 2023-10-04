using System;
namespace challenging2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string in line");
            string input = Console.ReadLine();
            Console.WriteLine("Input a character in line");
            char inputchar = Console.ReadLine()[0];
            int indexchar = input.IndexOf(inputchar);
            Console.WriteLine($"we have a string {input} and the charater we typed is {inputchar} and the position its {indexchar} ");
            Console.ReadKey();

        }
    }

}


