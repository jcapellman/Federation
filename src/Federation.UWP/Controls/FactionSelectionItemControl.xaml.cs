using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

using Federation.UWP.Enums;

namespace Federation.UWP.Controls
{
    public sealed partial class FactionSelectionItemControl : UserControl
    {
        public FactionSelectionItemControl()
        {
            this.InitializeComponent();
        }

        public Faction SelectedFaction
        {
            get => (Faction)GetValue(FactionProperty);
            set
            {
                SetValue(FactionProperty, value);

                imgFaction.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Factions/{value}.png"));
                tbName.Text = value.ToString();
            }
        }

        public bool Toggled
        {
            get => tbMain.IsChecked ?? false;

            set => tbMain.IsChecked = value;
        }

        public static readonly DependencyProperty ToggledProperty = DependencyProperty.Register("Toggled", typeof(bool), typeof(GalaxyMapItemControl), new PropertyMetadata(false));

        public static readonly DependencyProperty FactionProperty = DependencyProperty.Register("SelectedFaction", typeof(Faction), typeof(GalaxyMapItemControl), new PropertyMetadata(Faction.Federation));
    }
}