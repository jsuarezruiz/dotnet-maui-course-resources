namespace AnimationsPlayground;

public partial class RotatePage : ContentPage
{
	public RotatePage()
	{
		InitializeComponent();
	}

	async void OnClickedAsync(object sender, EventArgs e)
	{
		await Task.WhenAny(
            BotImg.RotateTo(360, 500, Easing.CubicInOut),
			BotImg.TranslateTo(0,-50, 250, Easing.CubicInOut)
        );
        await BotImg.TranslateTo(0, 0, 250, Easing.CubicInOut);
        BotImg.Rotation = 0;
	}
}

