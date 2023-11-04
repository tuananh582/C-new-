using System;
namespace inherit
{
    public class Tv:ElectricalDevice
    {
       

        public Tv(bool isOn, string brand):base(isOn,brand)
        {
            
        }
        
        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching Tv");
            }
            else
            {
                Console.WriteLine("Tv is switched off, switch it on first");
            }
        }
    }
}

