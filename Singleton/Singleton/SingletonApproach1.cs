namespace DesignPatterns.Singleton;

public class SingletonApproach1
{
    private static SingletonApproach1 _singletonApproach1;
    private SingletonApproach1()
    {
    }
    public static SingletonApproach1 getSingletonInstance()
    {
        if (_singletonApproach1 == null)
        {
            _singletonApproach1 = new SingletonApproach1();
        }
        return _singletonApproach1;
    }
}