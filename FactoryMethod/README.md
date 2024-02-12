## Factory Method

Factory method pattern is a creational design pattern that provides an interface for creating objects but allows subclasses to decide which class to instantiat

### Structure

1. ### Creator: 
   The abstract class that declares the factory method, which returns an object of type Product. It also may contain some default implementation of the factory method.
   ```DatabaseEngine.cs```
2. ### ConcreteCreator:
   The concrete class that implements the factory method to create and return a concrete product.
   ```PostgresEngine.cs , SqlServerEngine.cs```
3. ### Product:
   The abstract class that defines the interface of objects the factory method creates.
   ```IDatabase.cs```
4. ### ConcreteProduct:
   The concrete class that implements the Product interface.
   ```PostgresDatabase.cs , SqlServerDatabase.cs```

**Factory Method** in creator class is an abstract method that returns a product. The concrete creator class implements the factory method to create and return a concrete product.