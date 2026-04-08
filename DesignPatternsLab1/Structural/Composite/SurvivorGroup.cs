namespace DesignPatternsLab1.Structural.Composite
{
    public class SurvivorGroup : SurvivorComponent
    {
        private readonly string _groupName;

        public SurvivorGroup(string groupName) => _groupName = groupName;

        public override void ExecuteOrder(string order)
        {
            Console.WriteLine($"Group '{_groupName}' received order: {order}. Sub-units acting:");
            foreach (var child in Children)
            {
                child.ExecuteOrder(order);
            }
        }
    }
}