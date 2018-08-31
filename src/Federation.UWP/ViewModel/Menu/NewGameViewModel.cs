using System;
using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Enums;

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

        public NewGameViewModel()
        {
            MapSizeOptions = Enum.GetNames(typeof(Enums.GameSize)).ToList();
        }

        private Race _selectedRace;

        public void SetRace(Race race)
        {
            _selectedRace = race;
        }
    }
}