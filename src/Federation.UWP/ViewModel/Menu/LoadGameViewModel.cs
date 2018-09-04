using System.Collections.ObjectModel;
using System.Linq;

using Windows.UI.Xaml;

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

                GameItemsVisible = (value.Any() ? Visibility.Visible : Visibility.Collapsed);
            }
        }

        private MainGameItem _selectedGameItem;

        public MainGameItem SelectedGameItem
        {
            get => _selectedGameItem;

            set
            {
                _selectedGameItem = value;
                OnPropertyChanged();
                LoadGameButtonEnabled = value != null;
            }
        }

        private bool _loadGameButtonEnabled;

        public bool LoadGameButtonEnabled
        {
            get => _loadGameButtonEnabled;

            set
            {
                _loadGameButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        private Visibility _gameItemsVisible;

        public Visibility GameItemsVisible
        {
            get => _gameItemsVisible;

            set {
                _gameItemsVisible = value;
                OnPropertyChanged();
                NoGameTextVisible = (value == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed);
            }
        }

        private Visibility _noGameTextVisible;

        public Visibility NoGameTextVisible
        {
            get => _noGameTextVisible;

            set { _noGameTextVisible = value; OnPropertyChanged(); }
        }

        public LoadGameViewModel()
        {
            GameItems = new ObservableCollection<MainGameItem>(new LiteDBDAL().GetGameList());

            if (!GameItems.Any())
            {
                SelectedGameItem = null;

                return;
            }

            SelectedGameItem = GameItems.FirstOrDefault();
        }
    }
}