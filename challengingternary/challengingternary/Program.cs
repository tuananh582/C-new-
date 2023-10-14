using System;
namespace challengingternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperature = string.Empty;
            string inputValue = string.Empty;
            Console.WriteLine("Enter the current temperature");
            inputValue = Console.ReadLine();

            bool validInteger = int.TryParse(inputValue, out inputTemperature);
            if (validInteger)
            {
                temperature = (inputTemperature >= 16 && inputTemperature <= 28) ? "It's too cold here" : inputTemperature > 28 ? "It's hot here" : "";
                Console.WriteLine(temperature);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature ");
            }
            Console.ReadKey();
        }
    }


}

