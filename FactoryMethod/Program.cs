using Factory;

DatabaseEngine sqlServerEngine = new SqlServerEngine();
sqlServerEngine.SomeOperation();

DatabaseEngine postgresEngine = new PostgresEngine();
postgresEngine.SomeOperation();