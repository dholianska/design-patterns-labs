using DesignPatternsLab1.Structural.Bridge;

namespace DesignPatternsLab1.Structural.Bridge
{
    // Модифікація: Армована стрічка (зміцнення)
    public class ReinforcedUpgrade : IUpgrade
    {
        public void Attach() => Console.WriteLine("The handle is reinforced with tape and metal plates.");
        public void ExecuteEffect() => Console.WriteLine("The strike is heavy and much more durable.");
        public void Detach() => Console.WriteLine("The reinforcement is worn out.");
    }
}