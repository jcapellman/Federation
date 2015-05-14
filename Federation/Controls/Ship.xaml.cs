using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Federation.Controls {
    public partial class Ship : UserControl {
        public enum SHIPS {
            FEDERATION_AKIRA,
            FEDERATION_GALAXY,
            FEDERATION_DEFIANT,
            FEDERATION_EXCELSIOR,
            FEDERATION_RELIANT           
        }

        public Ship() {
            InitializeComponent();

            this.Loaded += FrameworkElement_Loaded;

            DataContext = this;
        }

        private void FrameworkElement_Loaded(object sender, RoutedEventArgs e) {
            MainImageSlideIn.Begin();
        }

        public SHIPS ShipType {
            set { MainImage.Source = new BitmapImage(new Uri("/Assets/Ships/" + value.ToString() + ".png", UriKind.Relative)); }

            get { return SHIPS.FEDERATION_AKIRA;}
        }

        public double ShipWidth
        {
            set { MainImage.Width = value;  }

            get { return MainImage.Width; }
        }

        public double ShipHeight
        {
            set { MainImage.Height = value; }

            get { return MainImage.Height; }
        }


        public KeyTime ShipDuration { get { return keyFrameEnd.KeyTime; } set { keyFrameEnd.KeyTime = value; } }

        
    }
}
