using ToDo.Data;
using ToDo.Models;
using ToDo.Services;

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
    readonly DialogService dialogService;

    public TodoItemPage(TodoItemDatabase todoItemDatabase, DialogService dialogService)
    {
        InitializeComponent();

        database = todoItemDatabase;
        this.dialogService = dialogService;
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Item.Name))
        {
            await dialogService.DisplayAlert("Name Required", "Please enter a name for the todo item.");
            return;
        }

        await database.SaveItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (Item.ID == 0)
            return;

        await database.DeleteItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}