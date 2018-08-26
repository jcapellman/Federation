using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Objects.UI;
using Federation.UWP.Views;

using NavigationViewItem = Windows.UI.Xaml.Controls.NavigationViewItem;

namespace Federation.UWP.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IList<NavigationItem> _pages = new List<NavigationItem>
        {
            new NavigationItem("galaxy_map", typeof(GalaxyMapPage), "Galaxy Map"),
            new NavigationItem("territory", typeof(TerritoryPage), "Territory"),
            new NavigationItem("shipyards", typeof(ShipyardsPage), "Shipyards"),
            new NavigationItem("research", typeof(ResearchPage), "Research"),
            new NavigationItem("resources", typeof(ResourcesPage), "Resources"),
            new NavigationItem("save_game", typeof(SaveGamePage), "Save Game"),
            new NavigationItem("quit_to_menu", typeof(MainMenuPage), "Quit to Main Menu")
        };

        private NavigationItem _selectedNavigationItem;

        public NavigationItem SelectedNavigationItem
        {
            get => _selectedNavigationItem;

            set
            {
                _selectedNavigationItem = value;

                OnPropertyChanged();
            }
        }

        public bool UpdateNavigationItem(string tagName)
        {
            SelectedNavigationItem = _pages.FirstOrDefault(p => p.Tag.Equals(tagName));

            return SelectedNavigationItem != null;
        }
    }
}