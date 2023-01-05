using ChatApp.Models;
using ChatApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChatApp.ViewModels
{
    public partial class DetailViewModel : ObservableObject, IQueryAttributable
    {
        readonly MessageService _messageService;

        public DetailViewModel(MessageService messageService)
        {
            _messageService = messageService;
        }

        public Message Info { get; private set; }

        [ObservableProperty]
        User user;

        [ObservableProperty]
        ObservableCollection<Message> messages;

        [RelayCommand]
        async Task GoBack(User user)
        {
            await Shell.Current.GoToAsync("..");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Info = query["Message"] as Message;

            if (Info == null)
                return;

            User = Info.Sender;
            Messages = new ObservableCollection<Message>(_messageService.GetMessages(User));
        }
    }
}