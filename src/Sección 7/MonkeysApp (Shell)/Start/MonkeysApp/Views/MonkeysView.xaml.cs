using MonkeysApp.ViewModels;

namespace MonkeysApp.Views;

public partial class MonkeysView : ContentPage
{
    public MonkeysView(MonkeysViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}