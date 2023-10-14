using System;
namespace operators
{

    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 5;
            //int num2 = 3;
            //int num3;
            //num3 = -num1;
            //Console.WriteLine("num3 is {0}", num3);
            //bool isSunny = true;
            //Console.WriteLine("is it {0}",!isSunny);
            //int num = 0;
            //num++;
            //Console.WriteLine("{0}",num);
            //Console.WriteLine("{0}",num++);
            //Console.WriteLine("{0}",++num);
            //Console.ReadKey();
            Console.WriteLine("What is the temperature like");
            string temperature = Console.ReadLine();
            //int numtemp = int.Parse(temperature);
            int numtemp;
            int number;
            bool UserEnterANumber = int.TryParse(temperature, out number);

            if (UserEnterANumber)
            {
                numtemp = number;

            }
            else
            {
                numtemp = 0;
                Console.WriteLine("Value entered, was no number!.0 set as temperature");

            }
            if (numtemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numtemp == 20)
            {
                Console.WriteLine("Pants and Pull over should be fine");
            }
            else if (numtemp > 30)
            {
                Console.WriteLine("It's super hot");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }
            Console.Read();

        }
    }
}



