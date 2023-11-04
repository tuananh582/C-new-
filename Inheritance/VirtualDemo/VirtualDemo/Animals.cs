using System;
namespace VirtualDemo
{
    public class Animals
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public bool isHungry { set; get; }

        public Animals(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            isHungry = true;
        }
        public virtual void MakeSound()
        {

        }
        public virtual void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}

