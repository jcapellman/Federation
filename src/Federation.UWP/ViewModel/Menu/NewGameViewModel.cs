using System;
using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Enums;
using Federation.UWP.Objects.Game;

namespace Federation.UWP.ViewModel.Menu
{
    public class NewGameViewModel : BaseViewModel
    {
        private List<string> _gameSizeOptions;

        public List<string> GameSizeOptions
        {
            get => _gameSizeOptions;

            set { _gameSizeOptions = value; OnPropertyChanged(); }
        }

        private string _selectedGameSize;

        public string SelectedGameSize
        {
            get => _selectedGameSize;

            set { _selectedGameSize = value; OnPropertyChanged(); }
        }

        public NewGameViewModel()
        {
            GameSizeOptions = Enum.GetNames(typeof(Enums.GameSize)).ToList();

            SelectedGameSize = GameSizeOptions.FirstOrDefault();
        }

        private Faction _selectedFaction;

        public void SetFaction(Faction faction)
        {
            _selectedFaction = faction;
        }

        public MainGameItem BuildGameObject() => new MainGameItem((GameSize)Enum.Parse(typeof(GameSize), SelectedGameSize), _selectedFaction);
    }
}