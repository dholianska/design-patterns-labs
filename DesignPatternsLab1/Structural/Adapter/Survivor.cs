using DesignPatternsLab1.Structural.Adapter;

namespace DesignPatternsLab1.Structural.Adapter
{
    public class Survivor
    {
        private readonly ISilentTransport _transport;

        public Survivor(ISilentTransport transport)
        {
            _transport = transport;
        }

        public void ScoutArea()
        {
            _transport.MoveQuietly();
        }
    }
}