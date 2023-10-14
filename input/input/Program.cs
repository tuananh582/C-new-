using System;
namespace input
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userinput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userinput);

            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time ");

            }
            catch (OverflowException)
            {
                //throw;

                //Console.WriteLine("Format exception, please enter the correct type next time ");
                Console.WriteLine("OverFlow Exception ");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }


            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't devide by zero!");
            }
            
            Console.ReadKey();


            //Console.WriteLine(Caculate());
            //Console.Read();
        }
        //public static int Caculate()
        //{
        //    Console.WriteLine("Please enter the first number");
        //    string numberIntput = Console.ReadLine();
        //    Console.WriteLine("Please enter the second number");
        //    string number2Input = Console.ReadLine();
        //    int num1 = int.Parse(numberIntput);
        //    int num2 = int.Parse(number2Input);
        //    int result = num1 + num2;
        //    return result;

        //}
    }


}

