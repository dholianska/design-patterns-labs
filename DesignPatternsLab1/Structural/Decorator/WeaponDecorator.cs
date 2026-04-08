using DesignPatternsLab1.Structural.Decorator;

namespace DesignPatternsLab1.Structural.Decorator
{
    public abstract class WeaponDecorator : IMeleeWeapon
    {
        protected readonly IMeleeWeapon DecoratedWeapon;

        protected WeaponDecorator(IMeleeWeapon weapon) => DecoratedWeapon = weapon;

        public virtual void Attack() => DecoratedWeapon.Attack();
        public virtual int GetAttackPower() => DecoratedWeapon.GetAttackPower();
        public virtual void FleeBattle() => DecoratedWeapon.FleeBattle();
    }
}