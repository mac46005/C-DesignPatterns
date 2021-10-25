
namespace CS_DesignPatterns.ClassLib.Classes.Singleton
{
    //* Singleton Design Pattern
    //? A Singleton is a class which only allows a single instance of it to be created. In the application run time, only one single instance of the singleton class will exist for all users.

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