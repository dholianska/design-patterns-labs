using DesignPatternsLab1.Structural.Decorator;
using System;

namespace DesignPatternsLab1.Structural.Decorator
{
    public class ReinforcedMachete : WeaponDecorator
    {
        public ReinforcedMachete(IMeleeWeapon weapon) : base(weapon) { }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("The metal plates strike with extra force!");
        }

        public override int GetAttackPower()
        {
            return base.GetAttackPower() + 15;
        }
    }
}