using System.Collections.ObjectModel;

using Federation.UWP.DAL;
using Federation.UWP.Objects.Game;

namespace Federation.UWP.ViewModel.Menu
{
    public class LoadGameViewModel : BaseViewModel
    {
        private ObservableCollection<MainGameItem> _gameItems;

        public ObservableCollection<MainGameItem> GameItems
        {
            get => _gameItems;

            set
            {
                _gameItems = value;

                OnPropertyChanged();
            }
        }

        public LoadGameViewModel()
        {
            GameItems = new ObservableCollection<MainGameItem>(new LiteDBDAL().GetGameList());
        }
    }
}