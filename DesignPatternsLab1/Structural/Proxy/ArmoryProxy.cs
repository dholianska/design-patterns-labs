using DesignPatternsLab1.Structural.Proxy;
using System;
using System.Collections.Generic;

namespace DesignPatternsLab1.Structural.Proxy
{
    public class ArmoryProxy : IArmory
    {
        private readonly RealArmory _realArmory = new();
        private readonly List<string> _trustedSurvivors = new() { "Joel", "Tommy", "Maria" };
        private int _currentPeopleInside = 0;
        private const int MaxCapacity = 2;

        public void Enter(string survivorName)
        {
            if (!_trustedSurvivors.Contains(survivorName))
            {
                Console.WriteLine($"ACCESS DENIED: {survivorName} is not trusted in Jackson!");
                return;
            }

            if (_currentPeopleInside >= MaxCapacity)
            {
                Console.WriteLine($"REJECTED: The armory is too crowded for {survivorName}!");
                return;
            }

            _realArmory.Enter(survivorName);
            _currentPeopleInside++;
        }
    }
}