using DesignPatternsLab1.Creational.Factory;

namespace DesignPatternsLab1.Creational.FactoryMethod
{
    public class CitySpawner : InfectedSpawner
    {
        public override IInfected CreateInfected() => new Runner();
    }
}