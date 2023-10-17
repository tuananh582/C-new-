using System;
namespace classes
{
    public class Car
    {
        private string _name;
        private int _hp;
        private string _color;
        private int _maxSpeed;
        //the public property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //auto implement property
        //public int MySpeedMax { get; set; }
        //Read only
        //public int MySpeedMax { get; } = 180;

        //only Set
        public int MySpeedMax
        {
            set
            {
                _maxSpeed = value;

            }
        }



        //
        public int Gethp()
        {
            return _hp * _hp;

        }

        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {
            if (name == "")
            {
                _name = "Default name";
            }
            else
            {
                _name = name;

            }
        }
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "red";
            _maxSpeed = 150;
            Drive();
        }
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            _hp = hp;
            Console.WriteLine(name + " was created");
            _color = color;
            Drive();
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

