using Windows.UI.Xaml.Controls;

using Federation.UWP.Controls;
using Federation.UWP.Enums;

namespace Federation.UWP.Views
{
    public sealed partial class GalaxyMapPage : Page
    {
        public GalaxyMapPage()
        {
            InitializeComponent();

            for (var x = 0; x < 25; x++)
            {
                ugMap.Children.Add(new GalaxyMapItemControl
                {
                    SelectedRace = Race.Cardassian
                });
            }
        }
    }
}