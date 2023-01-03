using CommunityToolkit.Mvvm.ComponentModel;
using MonkeysApp.Models;
using System.Collections.ObjectModel;
using Microsoft.Maui.Devices.Sensors;
using MapsPlayground.Models;

namespace MonkeysApp.ViewModels
{
    [QueryProperty(nameof(Monkey), "Monkey")]
    public partial class MonkeyDetailsViewModel : ObservableObject
    {
        public Monkey Monkey
        {
            set
            {
                LoadLocations(value);
            }
        }

        public ObservableCollection<Position> Locations { get; } = new();

        void LoadLocations(Monkey monkey)
        {
            if (monkey == null)
                return;

            Locations.Add(new Position(monkey.Name, monkey.Location, new Location(monkey.Latitude, monkey.Longitude)));
        }
    }
}