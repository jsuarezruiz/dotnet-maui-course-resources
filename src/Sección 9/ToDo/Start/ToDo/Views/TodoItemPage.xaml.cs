using ToDo.Data;
using ToDo.Models;

namespace ToDo.Views;

[QueryProperty("Item", "Item")]
public partial class TodoItemPage : ContentPage
{
    public TodoItem Item
	{
		get => BindingContext as TodoItem;
		set => BindingContext = value;
	}

    readonly TodoItemDatabase database;

    public TodoItemPage(TodoItemDatabase todoItemDatabase)
    {
        InitializeComponent();
        database = todoItemDatabase;
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Item.Name))
        {
            // Nombre requerido
            return;
        }

        // TODO: Insertar nuevo elementos en la base de datos
        await Shell.Current.GoToAsync("..");
    }

    async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (Item.ID == 0)
            return;

        // TODO: Eliminar nuevo elementos en la base de datos
        await Shell.Current.GoToAsync("..");
    }

    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}