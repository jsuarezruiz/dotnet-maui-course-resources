namespace ToDo.Services
{
    public class DialogService
    {
        public async Task DisplayAlert(string message)
        {
            var mainPage = Application.Current.MainPage;

            if (mainPage != null)
                await mainPage.DisplayAlert("ToDo", message, "OK");
        }

        public async Task DisplayAlert(string title, string message)
        {
            var mainPage = Application.Current.MainPage;

            if (mainPage != null)
                await mainPage.DisplayAlert(title, message, "OK");
        }
    }
}
