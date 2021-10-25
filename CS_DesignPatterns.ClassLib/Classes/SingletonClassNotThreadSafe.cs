//Not Thread-safe version of a Singleton
public sealed class SingletonClass
{
    private static SingletonClass _instance = null;
    private SingletonClass(){}
    public static SingletonClass SingleInstance{
        get{
            if(_instance == null){
                // Is is possible that two different threads reach this point at the same time,
                // so more than one instance can be created in a situation like this, because both will
                // pass the condition about _instance being null
                _instance = new SingletonClass();
            }
            return _instance;
        }
    }
}