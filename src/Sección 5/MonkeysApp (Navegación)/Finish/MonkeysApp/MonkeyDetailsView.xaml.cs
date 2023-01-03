namespace MonkeysApp.Views;

[QueryProperty(nameof(Monkey), "Monkey")]
public partial class MonkeyDetailsView : ContentPage
{
    Monkey _monkey;

    public MonkeyDetailsView()
	{
		InitializeComponent();

        BindingContext = this;
    }

    public Monkey Monkey
    {
        get { return _monkey; }
        set
        {
            _monkey = value;
            OnPropertyChanged();
        }
    }
}