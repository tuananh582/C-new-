﻿using System;
namespace inherit
{
    public class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwichOff()
        {
            IsOn = false;
        }
       

    }
}

