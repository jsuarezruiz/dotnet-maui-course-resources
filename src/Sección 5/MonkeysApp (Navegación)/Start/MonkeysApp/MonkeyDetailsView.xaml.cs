namespace MonkeysApp.Views;

// TODO: Capturar el parámetro enviado en la navegación.
// Pista: QueryProperty
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