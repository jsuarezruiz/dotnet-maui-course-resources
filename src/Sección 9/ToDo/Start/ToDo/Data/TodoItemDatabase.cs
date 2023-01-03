using SQLite;
using ToDo.Models;

namespace ToDo.Data;

public class TodoItemDatabase
{
    SQLiteAsyncConnection Database;

    public TodoItemDatabase()
    {
    }

    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        var result = await Database.CreateTableAsync<TodoItem>();
    }

    public async Task<List<TodoItem>> GetItemsAsync()
    {
        await Init();
        return await Database.Table<TodoItem>().ToListAsync();
    }

    public async Task<List<TodoItem>> GetItemsNotDoneAsync()
    {
        await Init();

        // TODO: Implementar el obtener todos los elementos de la base de datos.
        throw new NotImplementedException();
    }

    public async Task<TodoItem> GetItemAsync(int id)
    {
        await Init();

        // TODO: Implementar el obtener un elemento de la base de datos.
        throw new NotImplementedException();
    }

    public async Task<int> SaveItemAsync(TodoItem item)
    {
        await Init();

        // TODO: Implementar el insertar un elemento de la base de datos.
        throw new NotImplementedException();
    }

    public async Task<int> DeleteItemAsync(TodoItem item)
    {
        await Init();

        // TODO: Implementar el eliminar un elemento de la base de datos.
        throw new NotImplementedException();
    }
}