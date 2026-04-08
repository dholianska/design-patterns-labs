using DesignPatternsLab1.Structural.Adapter;

namespace DesignPatternsLab1.Structural.Adapter
{
    public class MotorboatAdapter : ISilentTransport
    {
        private readonly Motorboat _boat = new Motorboat();

        public void MoveQuietly()
        {
            _boat.StartEngine();
            Console.WriteLine("...but the survivor uses a custom muffler to stay hidden.");
        }
    }
}