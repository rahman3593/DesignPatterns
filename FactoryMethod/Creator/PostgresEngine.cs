namespace Factory;

// Concrete Creator : Postgres
public class PostgresEngine : DatabaseEngine
{
    public override IDatabase ConnectDatabase()
    {
        return new PostgresDatabase();
    }
}