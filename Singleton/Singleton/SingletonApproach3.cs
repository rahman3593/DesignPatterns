namespace DesignPatterns.Singleton;

public class SingletonApproach3
{
    private static SingletonApproach3 _singleton;
    private static readonly object _lock = new object();

    private SingletonApproach3()
    {
    }

    public static SingletonApproach3 getSingletonInstance()
    {
        lock (_lock)
        {
            if (_singleton == null)
            {
                _singleton = new SingletonApproach3();
            }
        }

        return _singleton;
    }
}