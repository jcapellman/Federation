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

        public bool Toggled
        {
            get => tbMain.IsChecked ?? false;

            set => tbMain.IsChecked = value;
        }

        public static readonly DependencyProperty ToggledProperty = DependencyProperty.Register("Toggled", typeof(bool), typeof(GalaxyMapItemControl), new PropertyMetadata(false));

        public static readonly DependencyProperty RaceProperty = DependencyProperty.Register("SelectedRace", typeof(Race), typeof(GalaxyMapItemControl), new PropertyMetadata(Race.Federation));
    }
}