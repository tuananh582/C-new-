using System;
class Program
{
    static void Main(string[] args)
    {
        //string myname = "Tuan Anh Dep Zai";
        //string message = "My name is " + myname;
        //Console.WriteLine("Before that" + " " + message);
        //string cap = message.ToUpper();
        //Console.WriteLine("After that " + " " + cap);
        //string lowcap = message.ToLower();
        //Console.WriteLine("Convert uppercase to lowercase " + " " + lowcap);
        //Console.Read();

        Console.Write("Enter a string and press enter:");
        string readInpute = Console.ReadLine();
        Console.WriteLine("you have entered[0]" + " " + readInpute);

        Console.Write("Enter a string and press enter : ");
        int acsiiValue = Console.Read();
        Console.WriteLine("ASCII value is [0]" + " " + acsiiValue);
        Console.ReadKey(); // it wait for a key press and it prevents the screen til a key is pressed 
    }

}
