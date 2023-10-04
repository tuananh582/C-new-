using System;
namespace parse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse
            //string myString = "15";
            //string mySecondString = "13";
            //int num1 = Int32.Parse(myString);
            //int num2 = Int32.Parse(mySecondString);
            //int resultInt = num1 + num2;
            //Console.WriteLine(resultInt);
            //string result = myString + mySecondString;
            //Console.WriteLine(result);
            //Console.Read();

            int age = 31;
            string name = "Tuan Anh";
            string job = "Ios Development";
            Console.WriteLine("String concatenation");
            //Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");
            //Console.WriteLine("Hello my name is {0}, I am {1} years old, and I am {2}  ", name, age,job);
            Console.WriteLine($"Hello my name is {name}, I am {age} years old and my job is {job} ");

            string names = "David Pham";
            int ages = 20;
            string message = string.Format("my name is {0} and i am {1} years old", names, ages);
            Console.WriteLine(message);



            string Pr = "Hello Tuan Anh";
            string substing = Pr.Substring(3, 5);
            Console.WriteLine(substing);

            //special charaters: can not console \ in order to fix that we using double backslashs \\
            string s1 = "this is a \"string\" with a slash \\ and a colon: ";
            Console.WriteLine(s1);
            string userinput;
            int a;
            Console.WriteLine("Enter a value");
            userinput = Console.ReadLine();
            //a = Convert.ToInt32(userinput);
            a = Int32.Parse(userinput);
            Console.WriteLine($"you enter {a}");


          
        }
    }

}


