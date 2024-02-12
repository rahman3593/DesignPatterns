namespace Factory;

// Concrete Creator : SqlServer
public class SqlServerEngine : DatabaseEngine
{
    public override IDatabase ConnectDatabase()
    {
        return new SqlServerDatabase();
    }
}