namespace AnimationsPlayground;

public partial class ScalePage : ContentPage
{
    public ScalePage()
    {
        InitializeComponent();
    }

    async void OnClickedAsync(object sender, EventArgs e)
    {
        await BotImg.ScaleTo(0, easing: Easing.SpringIn);
        await Task.Delay(1000);
        await BotImg.ScaleTo(1, easing: Easing.SpringOut);
    }
}

