using AnimationsPlayground.Extensions;

namespace AnimationsPlayground;

public partial class CustomAnimationPage : ContentPage
{
    public CustomAnimationPage()
    {
        InitializeComponent();
    }

    async void OnClickedAsync(object sender, EventArgs e)
    {

        Color bgColor = BackgroundColor;
        await Task.WhenAll(
          this.ColorTo(bgColor, GetRandomColour(), c => this.BackgroundColor = c)
        );
    }

    static readonly Random rand = new Random();

    Color GetRandomColour()
    {
        return Color.FromRgb(rand.Next(256), rand.Next(256), rand.Next(256));
    }
}