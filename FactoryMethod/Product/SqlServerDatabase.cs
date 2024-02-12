namespace Factory;

//Concrete Product : SQLServer
public class SqlServerDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connecting to SQL Server Database");
    }
}