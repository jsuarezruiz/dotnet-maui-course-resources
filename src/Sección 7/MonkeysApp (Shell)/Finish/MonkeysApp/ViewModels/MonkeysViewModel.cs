﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        readonly MonkeyService monkeyService;

        public MonkeysViewModel(MonkeyService monkeyService)
        {
            this.monkeyService = monkeyService;

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
                var monkeys = await monkeyService.GetMonkeys();

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