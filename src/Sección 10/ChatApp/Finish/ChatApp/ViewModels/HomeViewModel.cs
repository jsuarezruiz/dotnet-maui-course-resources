using ChatApp.Models;
using ChatApp.Services;
using ChatApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChatApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        readonly MessageService _messageService;

        public HomeViewModel(MessageService messageService)
        {
            _messageService = messageService;

            LoadData();
        }

        [ObservableProperty]
        ObservableCollection<User> users;

        [ObservableProperty]
        ObservableCollection<Message> recentChat;

        [RelayCommand]
        async Task GoToDetails(Message message)
        {
            if (message == null)
                return;

            await Shell.Current.GoToAsync(nameof(DetailView), true, new Dictionary<string, object>
            {
                {"Message", message }
            });
        }

        void LoadData()
        {
            Users = new ObservableCollection<User>(_messageService.GetUsers());
            RecentChat = new ObservableCollection<Message>(_messageService.GetChats());
        }
    }
}