using System;
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //myCar.Name = "MyAudiA3";
            //myCar.Details();
            //myCar.MySpeedMax = 180; //set
            myCar.MySpeedMax = 10;
            Console.WriteLine("Maxseed is "+myCar.MySpeedMax);
            //Console.WriteLine(myCar.Gethp());
            ////myCar.setName("my best car");
            ////Console.WriteLine("My car name is " + myCar.getName());
            //myCar.Details();
            //Car audi = new Car("Audi A4", 250, "blue");
            ////audi.Drive();
            //audi.Details();
            //Car bmw = new Car("BMW M5", 350);
            ////bmw.Drive();
            //bmw.Details();

            //Console.WriteLine("Press 1 to stop the car");
            //string userInput = Console.ReadLine();
            //if (userInput == "1")
            //{
            //    audi.CarStop();

            //}
            //else
            //{
            //    Console.WriteLine("Car is jummping");
            //}
        }
    }

}


