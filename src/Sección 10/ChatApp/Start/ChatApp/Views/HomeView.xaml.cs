using ChatApp.ViewModels;

namespace ChatApp.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView(HomeViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}