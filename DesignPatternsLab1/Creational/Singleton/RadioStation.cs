namespace DesignPatternsLab1.Creational.Singleton
{
    public sealed class RadioStation
    {
        private static RadioStation _instance;
        private static readonly object _lock = new object();

        private RadioStation()
        {
            Console.WriteLine("[System] An old radio tower has been found. The signal is weak but stable.");
        }

        public static RadioStation GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new RadioStation();
                    }
                }
            }
            return _instance;
        }

        public string GetBroadcast()
        {
            return "A voice from the walkie-talkie: 'If you can hear this, you are not alone'";
        }
    }
}