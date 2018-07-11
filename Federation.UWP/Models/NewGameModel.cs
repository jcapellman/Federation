using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Federation.lib.Enums;
using Federation.lib.Objects;

namespace Federation.UWP.Models {
    public class NewGameModel : INotifyPropertyChanged {
        public NewGameModel() { Difficulties = new List<string>(Enum.GetNames(typeof (Difficulty))); }

        private List<string> _difficulty;

        public List<string> Difficulties {
            get { return _difficulty; }
            set { _difficulty = value; OnPropertyChanged(); }
        }

        private string _playerName;

        public string PlayerName {
            get { return _playerName; }
            set { _playerName = value; OnPropertyChanged(); }
        }

        public Game CreateGame() {
            return new Game(PlayerName, (Difficulty)Enum.Parse(typeof(Difficulty), _difficulty[0]));
        }

#region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
#endregion
    }
}
