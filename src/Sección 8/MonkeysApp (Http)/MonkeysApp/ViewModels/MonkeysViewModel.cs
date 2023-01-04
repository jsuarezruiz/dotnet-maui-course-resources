using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeysApp.Models;
using MonkeysApp.Services;
using MonkeysApp.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MonkeysApp.ViewModels
{
    public partial class MonkeysViewModel : ObservableObject
    {  
        readonly MonkeyService _monkeyService;
        readonly IConnectivity _connectivity;

        public MonkeysViewModel(MonkeyService monkeyService, IConnectivity connectivity)
        {
            _monkeyService = monkeyService;
            _connectivity = connectivity;

            _ = GetMonkeysAsync();
        }

        public ObservableCollection<Monkey> Monkeys { get; } = new();

        [RelayCommand]
        async Task GoToDetails(Monkey monkey)
        {
            if (monkey == null)
                return;

            await Shell.Current.GoToAsync(nameof(MonkeyDetailsView), true, new Dictionary<string, object>
            {
                {"Monkey", monkey }
            });
        }

        async Task GetMonkeysAsync()
        {
            try
            {
                if (_connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("No connectivity!",
                        $"Please check internet and try again.", "OK");
                    return;
                }

                var monkeys = await _monkeyService.GetMonkeys();

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