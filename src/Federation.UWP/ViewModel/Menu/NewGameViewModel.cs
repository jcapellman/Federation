using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Federation.UWP.Enums;
using Federation.UWP.Objects.UI;

namespace Federation.UWP.ViewModel.Menu
{
    public class NewGameViewModel : BaseViewModel
    {
        private List<string> _mapSizeOptions;

        public List<string> MapSizeOptions
        {
            get => _mapSizeOptions;

            set { _mapSizeOptions = value; OnPropertyChanged(); }
        }

        private ObservableCollection<RaceSelectionItem> _races;

        public ObservableCollection<RaceSelectionItem> Races
        {
            get => _races;

            set { _races = value; OnPropertyChanged(); }
        }

        public NewGameViewModel()
        {
            MapSizeOptions = Enum.GetNames(typeof(Enums.GameSize)).ToList();

            Races = new ObservableCollection<RaceSelectionItem>();

            foreach (var raceName in Enum.GetNames(typeof(Race)))
            {
                Races.Add(new RaceSelectionItem(raceName));
            }
        }
    }
}