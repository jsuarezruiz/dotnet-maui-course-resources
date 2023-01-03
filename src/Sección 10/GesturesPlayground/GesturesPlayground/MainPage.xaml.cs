namespace GesturesPlayground;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void OnImageButtonClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TapInsideImage());
	}

    void OnFrameButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TapInsideFrame());
    }

    void OnXamlButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TapInsideFrameXaml());
    }
}

