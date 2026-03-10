namespace DesignPatternsLab1.Creational.Factory
{
    public static class InfectedFactory
    {
        public static IInfected CreateInfected(InfectedType type)
        {
            return type switch
            {
                InfectedType.Runner => new Runner(),
                InfectedType.Clicker => new Clicker(),
                _ => throw new ArgumentException("Unknown type of the infected")
            };
        }
    }
}