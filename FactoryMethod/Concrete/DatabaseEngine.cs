namespace Factory;
// Creator
public abstract class DatabaseEngine
{
    // Factory Method
    public abstract IDatabase ConnectDatabase();

    public void SomeOperation()
    {
        IDatabase database = ConnectDatabase();
        database.Connect();
    }
}