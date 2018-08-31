using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

using Federation.UWP.Enums;

namespace Federation.UWP.Controls
{
    public sealed partial class RaceSelectionItemControl : UserControl
    {
        public RaceSelectionItemControl()
        {
            this.InitializeComponent();
        }

        public Race SelectedRace
        {
            get => (Race)GetValue(RaceProperty);
            set
            {
                SetValue(RaceProperty, value);

                imgRace.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Races/{value}.png"));
                tbName.Text = value.ToString();
            }
        }

        public static readonly DependencyProperty RaceProperty = DependencyProperty.Register("SelectedRace", typeof(Race), typeof(GalaxyMapItemControl), new PropertyMetadata(Race.Federation));
    }
}