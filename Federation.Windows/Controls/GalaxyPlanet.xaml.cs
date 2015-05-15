using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Federation.PCL.Objects;

namespace Federation.WindowsUniversal.Controls {
    public partial class GalaxyPlanet : UserControl {
        public GalaxyPlanet() {
            InitializeComponent();
        }

        private Planets _planetObject;

        public Planets PlanetObject { get { return _planetObject; } set { _planetObject = value; ibBackground.ImageSource = new BitmapImage(new Uri(_planetObject.PlanetTexture, UriKind.Relative)); } }

        private BaseObject.RACE _race;

        public BaseObject.RACE Race { get { return _race; } set { _race = value; imgRace.Source = new BitmapImage(new Uri("/Assets/Races/" + value + ".png", UriKind.Relative)); } }

        public void Connect(int connectionId, object target)
        {
            
        }
    }
}
