using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using Federation.UWP.Controls;
using Federation.UWP.Objects.Game;

namespace Federation.UWP.Views
{
    public sealed partial class GalaxyMapPage : Page
    {
        public GalaxyMapPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ugMap.Children.Clear();

            var gameItem = (MainGameItem) e.Parameter;

            if (gameItem == null)
            {
                return;
            }

            foreach (var galaxyMapItem in gameItem.GalaxyMapItems)
            {
                ugMap.Children.Add(new GalaxyMapItemControl
                {
                    SelectedRace = galaxyMapItem.Race
                });
            }
        }
    }
}