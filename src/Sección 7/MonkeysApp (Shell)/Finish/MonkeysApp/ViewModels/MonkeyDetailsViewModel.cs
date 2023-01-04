using CommunityToolkit.Mvvm.ComponentModel;
using MonkeysApp.Models;

namespace MonkeysApp.ViewModels
{
    [QueryProperty(nameof(Monkey), "Monkey")]
    public partial class MonkeyDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        Monkey monkey;
    }
}