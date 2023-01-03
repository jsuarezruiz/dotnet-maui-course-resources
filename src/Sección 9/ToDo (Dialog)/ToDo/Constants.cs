namespace ToDo;

public static class Constants
{
    public const string DatabaseFilename = "TodoSQLite.db3";

    public const SQLite.SQLiteOpenFlags Flags =
        // Open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // Create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // Enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

    public static string DatabasePath => 
        Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
}
