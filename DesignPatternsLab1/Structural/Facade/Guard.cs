using DesignPatternsLab1.Structural.Facade;
using System.Xml.Linq;

namespace DesignPatternsLab1.Structural.Facade
{
   public class Guard : JacksonWorker
    {
        public Guard(string name) : base(name) { }
        public override void DoWork() => Console.WriteLine($"{Name} is scanning the perimeter.");
    }
}