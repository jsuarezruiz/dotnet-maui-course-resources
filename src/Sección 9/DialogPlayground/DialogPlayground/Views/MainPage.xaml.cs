namespace DialogPlayground
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnAlertButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlertPage());
        }

        void OnActionSheetButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ActionSheetPage());
        }

        void OnPromptButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PromptPage());
        }
    }
}