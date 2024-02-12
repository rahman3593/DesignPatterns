namespace Factory;

//Concrete Product : Postgres
public class PostgresDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connecting to Postgres Database");
    }
}