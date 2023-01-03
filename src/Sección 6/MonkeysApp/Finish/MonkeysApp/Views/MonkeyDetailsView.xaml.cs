using MonkeysApp.ViewModels;

namespace MonkeysApp.Views;

public partial class MonkeyDetailsView : ContentPage
{
    public MonkeyDetailsView(MonkeyDetailsViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}