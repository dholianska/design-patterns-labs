namespace DesignPatternsLab1.Creational.AbstractFactory
{
    public class FedraFactory : IFactionFactory
    {
        public ISurvivor CreateSurvivor() => new FedraSoldier();
        public IWeapon CreateWeapon() => new AssaultRifle();
        public IBase CreateBase() => new MilitaryZone();
    }

    public class FireflyFactory : IFactionFactory
    {
        public ISurvivor CreateSurvivor() => new FireflyRebel();
        public IWeapon CreateWeapon() => new HuntingRifle();
        public IBase CreateBase() => new SecretLab();
    }
}