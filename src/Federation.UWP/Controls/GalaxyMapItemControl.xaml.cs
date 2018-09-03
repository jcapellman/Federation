using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

using Federation.UWP.Enums;

namespace Federation.UWP.Controls
{
    public sealed partial class GalaxyMapItemControl : UserControl
    {
        public Faction SelectedFaction
        {
            get => (Faction) GetValue(FactionProperty);
            set
            {
                SetValue(FactionProperty, value);

                imgRace.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Factions/{value}.png"));
            }
        }

        public static readonly DependencyProperty FactionProperty = DependencyProperty.Register("SelectedFaction", typeof(Faction), typeof(GalaxyMapItemControl), new PropertyMetadata(Faction.Federation));

        public GalaxyMapItemControl()
        {
            this.InitializeComponent();
        }
    }
}