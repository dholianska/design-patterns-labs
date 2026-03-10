using DesignPatternsLab1.Creational.Factory;

namespace DesignPatternsLab1.Creational.FactoryMethod
{
    public class SubwaySpawner : InfectedSpawner
    {
        public override IInfected CreateInfected() => new Clicker();
    }
}