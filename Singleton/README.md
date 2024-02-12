## Singleton Pattern
The Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance. It's commonly used when there's a need for exactly one instance of a class, which should be accessible from any part of the program.

Key features of the Singleton pattern:

### Private Constructor: 
The Singleton class typically has a private constructor to prevent other classes from directly creating instances of it.

### Static Instance: 
The Singleton class contains a static member that holds the single instance of the class. This instance is usually created either at the time of class loading or lazily upon the first request for the instance.

### Global Access Point: 
The Singleton class provides a static method or property to access the single instance, ensuring that all clients use the same instance.

### 4 Basic Approaches to Implement Singleton Pattern:
1. Basic Singleton Pattern - Not Thread Safe 
2. With Locking Mechanism - Thread Safe 
3. With Double-Checked Locking - Thread Safe 
4. With Lazy<T> - Thread Safe