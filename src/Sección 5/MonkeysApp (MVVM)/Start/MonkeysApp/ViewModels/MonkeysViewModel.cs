using MonkeysApp.Models;
using MonkeysApp.Services;
using MonkeysApp.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MonkeysApp.ViewModels
{
    public partial class MonkeysViewModel : BindableObject
    {
        readonly MonkeyService monkeyService;

        public MonkeysViewModel(MonkeyService monkeyService)
        {
            this.monkeyService = monkeyService;

            _ = GetMonkeysAsync();
        }

        public ObservableCollection<Monkey> Monkeys { get; } = new();

        public ICommand GoToDetailsCommand => new Command<Monkey>(GoToDetails);

        void GoToDetails(Monkey monkey)
        {
            if (monkey == null)
                return;

            // TODO: Navega a los detalles usando el método GoToAsync pasando como parámetro
            // el monkey recibido en el comando.
        }

        async Task GetMonkeysAsync()
        {
            try
            {
                List<Monkey> monkeys = null; // TODO: Obtiene los monos del servicio.

                if (Monkeys.Count != 0)
                    Monkeys.Clear();

                foreach (var monkey in monkeys)
                    Monkeys.Add(monkey);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get data: {ex.Message}");
            }
        }
    }
}