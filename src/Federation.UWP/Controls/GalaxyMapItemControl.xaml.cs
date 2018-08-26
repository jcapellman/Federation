using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

using Federation.UWP.Enums;

namespace Federation.UWP.Controls
{
    public sealed partial class GalaxyMapItemControl : UserControl
    {
        public Race SelectedRace
        {
            get => (Race) GetValue(RaceProperty);
            set
            {
                SetValue(RaceProperty, value);

                imgRace.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Races/{value}.png"));
            }
        }

        public static readonly DependencyProperty RaceProperty = DependencyProperty.Register("SelectedRace", typeof(Race), typeof(GalaxyMapItemControl), new PropertyMetadata(Race.Federation));

        public GalaxyMapItemControl()
        {
            this.InitializeComponent();
        }
    }
}