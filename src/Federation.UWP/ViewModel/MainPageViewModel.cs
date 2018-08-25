using System;
using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Views;

using NavigationViewItem = Windows.UI.Xaml.Controls.NavigationViewItem;

namespace Federation.UWP.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IList<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
            ("galaxy_map", typeof(GalaxyMapPage)),
            ("territory", typeof(TerritoryPage)),
            ("shipyards", typeof(ShipyardsPage)),
            ("research", typeof(ResearchPage)),
            ("resources", typeof(ResourcesPage)),
            ("save_game", typeof(SaveGamePage)),
            ("quit_to_menu", typeof(MainMenuPage)),
        };

        public Type GetSelectedPageType(NavigationViewItem selectedNavItem)
        {
            var item = _pages.First(p => p.Tag.Equals(selectedNavItem.Tag));

            return item.Page;
        }
    }
}