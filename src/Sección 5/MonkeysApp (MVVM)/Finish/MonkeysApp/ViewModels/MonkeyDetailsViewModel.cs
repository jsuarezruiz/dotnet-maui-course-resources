using MonkeysApp.Models;

namespace MonkeysApp.ViewModels
{
    [QueryProperty(nameof(Monkey), "Monkey")]
    public partial class MonkeyDetailsViewModel : BindableObject
    {
        Monkey monkey;

        public Monkey Monkey
        {
            get { return monkey; }
            set
            {
                monkey = value;
                OnPropertyChanged();
            }
        }
    }
}