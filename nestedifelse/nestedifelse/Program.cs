using System;
namespace nestedifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter ur name ? ");
            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");


                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there ,Admin!");


            }
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged");
            }
            Console.Read();

        }

    }
}



