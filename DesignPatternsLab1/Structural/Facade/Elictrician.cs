using DesignPatternsLab1.Structural.Facade;
using System.Xml.Linq;

namespace DesignPatternsLab1.Structural.Facade
{
    public class Electrician : JacksonWorker
    {
        public Electrician(string name) : base(name) { }
        public override void DoWork() => Console.WriteLine($"{Name} is fixing the power lines.");
    }

}