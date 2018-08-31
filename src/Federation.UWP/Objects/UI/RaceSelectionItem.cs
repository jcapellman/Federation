using System;

using Windows.UI.Xaml.Media.Imaging;

namespace Federation.UWP.Objects.UI
{
    public class RaceSelectionItem
    {
        public string Name { get; set; }

        public BitmapImage Image { get; set; }

        public RaceSelectionItem(string raceName)
        {
            Name = raceName;

            Image = new BitmapImage(new Uri($"ms-appx:///Assets/Races/{raceName}.png"));
        }
    }
}