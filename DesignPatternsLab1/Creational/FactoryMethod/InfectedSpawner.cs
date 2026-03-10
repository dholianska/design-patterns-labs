using DesignPatternsLab1.Creational.Factory;

namespace DesignPatternsLab1.Creational.FactoryMethod
{
    public abstract class InfectedSpawner
    {
        public abstract IInfected CreateInfected();

        public void SpawnEnemy()
        {
            var infected = CreateInfected();
            Console.WriteLine($"[Warning zone]: {infected.GetWarning()}");
        }
    }
}