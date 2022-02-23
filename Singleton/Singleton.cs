namespace Singleton
{
    public class Singleton
    {
        private Singleton()
        {
            Description = string.Format("Number of this instance - {0}", ++_instanceNumber);
        }

        private int _instanceNumber = 0;
        private static Singleton _instance;
        private static object _locker = new object();
        public string Description { get; private set; }

        public static Singleton GetInstance()
        {
            lock(_locker)
            {
                if (_instance is null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }
}
