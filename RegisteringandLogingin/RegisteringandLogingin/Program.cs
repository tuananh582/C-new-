using System;

namespace RegisteringandLogingin
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            int temp = 30;
            string tempara;
            tempara = temp > 30 ? "gas" : temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter {0}", tempara);
            Console.Read();
        }
        public static void Register()
        {
            Console.WriteLine("Please enter your username ? ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password?");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("---------------------------------");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login Failed");
                }
            }
            else
            {
                Console.WriteLine("Failed Wrong.Restart Program");
            }
        }
    }


}


