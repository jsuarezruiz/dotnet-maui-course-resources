using MonkeysApp.Models;

namespace MonkeysApp.ViewModels
{
    // TODO: Usa QueryProperty para capturar el parámetro pasado en la navegación.
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