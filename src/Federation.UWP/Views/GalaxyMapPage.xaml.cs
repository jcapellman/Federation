using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Federation.UWP.Views
{
    public sealed partial class GalaxyMapPage : Page
    {
        public GalaxyMapPage()
        {
            this.InitializeComponent();

            var federationImage = new BitmapImage(new Uri("ms-appx:///Assets/Races/Federation.png"));

            for (var x = 0; x < 5; x++)
            {
                for (var y = 0; y < 5; y++)
                {
                    ugMap.Children.Add(new Image
                    {
                        Source = federationImage
                    });
                }
            }
        }
    }
}