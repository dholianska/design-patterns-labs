using DesignPatternsLab1.Structural.Flyweight;
using System;

namespace DesignPatternsLab1.Structural.Flyweight
{
    public class PistolAmmo : IAmmo
    {
        private readonly string _name = "9mm Round";
        private readonly string _icon = "---[o]";

        public void Display(int slotNumber)
        {
            Console.WriteLine($"Ammo {_name} {_icon} shown in backpack slot: {slotNumber}");
        }
    }
}