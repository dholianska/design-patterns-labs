using DesignPatternsLab1.Structural.Proxy;
using System;

namespace DesignPatternsLab1.Structural.Proxy
{
    public class RealArmory : IArmory
    {
        public void Enter(string survivorName)
        {
            Console.WriteLine($"{survivorName} has entered the armory and is taking supplies.");
        }
    }
}