using System;
namespace Conversion
{

    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myDouble = myFloat;

            int myInt;
            //explicit conversion
            //cast double to int
            myInt = (int)myDouble;


            //type Conversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;
            string myboolString = sunIsShining.ToString();
            Console.WriteLine(myboolString);
            Console.WriteLine(myString);
            Console.WriteLine(myFloatString);
            Console.WriteLine(myInt);
            Console.Read();
        }
    }

}


