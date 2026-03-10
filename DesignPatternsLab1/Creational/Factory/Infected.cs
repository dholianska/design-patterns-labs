namespace DesignPatternsLab1.Creational.Factory
{
    public class Runner : IInfected
    {
        public string GetWarning() => "Runner: *rapid breathing and stomping feet*";
    }

    public class Clicker : IInfected
    {
        public string GetWarning() => "Clicker: *click and metallic grinding sound*";
    }
}