using DesignPatterns.Singleton;

// Basic Singleton Pattern - Not Thread Safe 
var approach1Instance1 = SingletonApproach1.getSingletonInstance();
var approach1Instance2 = SingletonApproach1.getSingletonInstance();
Console.WriteLine(approach1Instance1 == approach1Instance2); // True

// With Locking Mechanism - Thread Safe 
var approach2Instance1 = SingletonApproach2.getSingletonInstance();
var approach2Instance2 = SingletonApproach2.getSingletonInstance();
Console.WriteLine(approach2Instance1 == approach2Instance2); // True

// With Double-Checked Locking - Thread Safe 
var approach3Instance1 = SingletonApproach3.getSingletonInstance();
var approach3Instance2 = SingletonApproach3.getSingletonInstance();
Console.WriteLine(approach3Instance1 == approach3Instance2); // True

// With Lazy<T> - Thread Safe
var approach4Instance1 = SingletonApproach4.Instance;
var approach4Instance2 = SingletonApproach4.Instance;
Console.WriteLine(approach4Instance1 == approach4Instance2); // True