using System;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Federation.WindowsUniversal.Helpers {
    public partial class jcMediaElement : UserControl {
        private readonly MediaElement _mediaElement;

        public double MediaWidth {
            get { return _mediaElement.Width; }

            set {
                _mediaElement.Width = value;
                Width = value;
            }
        }

        public double MediaHeight {
            get { return _mediaElement.Height; }

            set {
                _mediaElement.Height = value;
                Height = value;
            }   
        }

        public bool AutoPlay { get { return _mediaElement.AutoPlay; } set { _mediaElement.AutoPlay = value; } }

        public bool Loop { get; set; }


        public string Source { get; set; }

        public jcMediaElement() {
            _mediaElement = new MediaElement();

            Loaded += FrameworkElement_Loaded;
        }

        private void FrameworkElement_Loaded(object sender, RoutedEventArgs e) {


            _mediaElement.MediaEnded += _mediaElement_MediaEnded1;

            _mediaElement.Source = new Uri(Source, UriKind.Relative);

            if (AutoPlay) { _mediaElement.Play(); }
        }

        private void _mediaElement_MediaEnded1(object sender, RoutedEventArgs e) {
            if (Loop) {
                _mediaElement.Play();
            }
        }
    }
}