using DesignPatternsLab1.Structural.Bridge;

namespace DesignPatternsLab1.Structural.Bridge
{
    // Модифікація: Леза від циркулярної пилки
    public class SawBladeUpgrade : IUpgrade
    {
        public void Attach() => Console.WriteLine("The saw blades are bolted to the weapon.");
        public void ExecuteEffect() => Console.WriteLine("The weapon tears through the infected with extra damage!");
        public void Detach() => Console.WriteLine("The blades have broken off.");
    }
}