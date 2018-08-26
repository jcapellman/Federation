using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Enums;
using Federation.UWP.Objects.UI;
using Federation.UWP.Views;

namespace Federation.UWP.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IList<NavigationItem> _pages = new List<NavigationItem>
        {
            new NavigationItem("galaxy_map", typeof(GalaxyMapPage), LocalizedStrings.MainNavigation_GalaxyMap),
            new NavigationItem("territory", typeof(TerritoryPage), LocalizedStrings.MainNavigation_Territory),
            new NavigationItem("shipyards", typeof(ShipyardsPage), LocalizedStrings.MainNavigation_Shipyards),
            new NavigationItem("research", typeof(ResearchPage), LocalizedStrings.MainNavigation_Research),
            new NavigationItem("resources", typeof(ResourcesPage), LocalizedStrings.MainNavigation_Resources),
            new NavigationItem("save_game", typeof(SaveGamePage), LocalizedStrings.MainNavigation_SaveGame),
            new NavigationItem("quit_to_menu", typeof(MainMenuPage), LocalizedStrings.MainNavigation_QuitToMainMenu)
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