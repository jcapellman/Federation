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
            ("shipyards", typeof(ShipyardsPage))
        };

        public Type GetSelectedPageType(NavigationViewItem selectedNavItem)
        {
            var item = _pages.First(p => p.Tag.Equals(selectedNavItem.Tag));

            return item.Page;
        }
    }
}