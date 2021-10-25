
namespace CS_DesignPatterns.ClassLib.Classes
{
    //Not Thread-safe version of a Singleton
    public sealed class SingletonClassNotThreadSafe
    {
        private static SingletonClassNotThreadSafe _instance = null;
        private SingletonClassNotThreadSafe() { }
        public static SingletonClassNotThreadSafe SingleInstance
        {
            get
            {
                if (_instance == null)
                {
                    // Is is possible that two different threads reach this point at the same time,
                    // so more than one instance can be created in a situation like this, because both will
                    // pass the condition about _instance being null
                    _instance = new SingletonClassNotThreadSafe();
                }
                return _instance;
            }
        }
    }
}