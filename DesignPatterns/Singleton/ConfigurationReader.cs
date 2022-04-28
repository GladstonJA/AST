using System;

namespace Singleton
{
    public class ConfigurationReader
    {
        private static ConfigurationReader _instance = default(ConfigurationReader);
        private static object _lock = new object();

        protected ConfigurationReader() { }

        public static ConfigurationReader Instance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationReader();
                    }
                }
            }

            return _instance;
        }
    }
}
