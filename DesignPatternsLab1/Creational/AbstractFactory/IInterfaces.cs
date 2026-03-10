namespace DesignPatternsLab1.Creational.AbstractFactory
{
    public interface ISurvivor { string GetDescription(); }
    public interface IWeapon { string GetStats(); }
    public interface IBase { string GetLocation(); }

    public interface IFactionFactory
    {
        ISurvivor CreateSurvivor();
        IWeapon CreateWeapon();
        IBase CreateBase();
    }
}