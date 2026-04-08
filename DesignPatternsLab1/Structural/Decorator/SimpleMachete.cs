using DesignPatternsLab1.Structural.Decorator;
using System;

namespace DesignPatternsLab1.Structural.Decorator
{
    public class SimpleMachete : IMeleeWeapon
    {
        public void Attack() => Console.WriteLine("The survivor attacks with a basic machete!");
        public int GetAttackPower() => 20;
        public void FleeBattle() => Console.WriteLine("The survivor retreats with the machete.");
    }
}