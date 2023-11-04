using System;
namespace VirtualDemo
{
    public class Dog : Animals
    {

        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            //Default
            IsHappy = true;
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wuuuuf!");
        }
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
                //Console.WriteLine(" is Jumping");
            }
        }
    }
}

