using ToDo.Views;

namespace ToDo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
    }
}
