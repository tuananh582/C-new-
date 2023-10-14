using System;
namespace classes
{
    public class Car
    {
        private string _name;
        private int _hp;
        private string _color;


        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            _hp = hp;
            Console.WriteLine(name + " was created");
            _color = color;
        }
        public void Drive()
        {
            Console.WriteLine(_name + " is Driving ");
        }
        public void CarStop()
        {
            Console.WriteLine(_name + " is stopping");
        }
        public void Details()
        {
            Console.WriteLine("The " + _color + " car " + _name + " has " + _hp + " hp");
        }
    }
}

