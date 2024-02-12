namespace DesignPatterns.Singleton;

public class SingletonApproach2
{
    private static SingletonApproach2 _singleton;
    private static readonly object _lock = new object();

    private SingletonApproach2()
    {
    }

    public static SingletonApproach2 getSingletonInstance()
    {
        lock (_lock)
        {
            if (_singleton == null)
            {
                _singleton = new SingletonApproach2();
            }
        }

        return _singleton;
    }
}