using System;
namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomeThingSpecific("I am Pham Tuan Anh and I am 20 years old ");
           
            Console.WriteLine(Add(15, 32));
            Console.Read();
        }
        // Beacause the main method is static void so the another method wouble be satitic void 
        public static void WriteSomething()
        {
            Console.WriteLine("I am Called from a method ");
        }
        public static void WriteSomeThingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }

}


