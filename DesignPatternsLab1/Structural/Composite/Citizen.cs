namespace DesignPatternsLab1.Structural.Composite
{
    public class Citizen : SurvivorComponent
    {
        private readonly string _name;

        public Citizen(string name) => _name = name;

        public override void ExecuteOrder(string order)
        {
            Console.WriteLine($"  Survivor {_name} is performing order: {order}");
        }
    }
}