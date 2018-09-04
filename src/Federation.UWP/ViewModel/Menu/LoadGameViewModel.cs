using System.Collections.ObjectModel;
using System.Linq;

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

        private MainGameItem _selectedGameItem;

        public MainGameItem SelectedGameItem
        {
            get => _selectedGameItem;

            set { _selectedGameItem = value; OnPropertyChanged(); }
        }

        public LoadGameViewModel()
        {
            GameItems = new ObservableCollection<MainGameItem>(new LiteDBDAL().GetGameList());

            if (!GameItems.Any())
            {
                return;
            }

            SelectedGameItem = GameItems.FirstOrDefault();
        }
    }
}