namespace DesignPatterns.Singleton;

public class SingletonApproach4
{
    private static Lazy<SingletonApproach4> _Singleton = new(() => new SingletonApproach4());

    public static SingletonApproach4 Instance => _Singleton.Value;

    private SingletonApproach4()
    {
    }
}