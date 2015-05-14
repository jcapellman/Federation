using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

using Microsoft.Phone.Controls;
using Microsoft.Phone.BackgroundAudio;

namespace Federation {
    public partial class MainPage : PhoneApplicationPage, INotifyPropertyChanged {
        private AudioTrack getRandomTrack() {
            var rnd = new Random((int) DateTime.Now.Ticks);

            var path = new Uri(String.Format("Assets/Music/{0}.mp3", rnd.Next(1, 1)), UriKind.RelativeOrAbsolute);

            return new AudioTrack(path,
                "Federation",
                "Jarred Capellman",
                "Federation OST",
                null);
        }

        public MainPage() {
            InitializeComponent();

            this.DataContext = this;

            BackgroundAudioPlayer.Instance.PlayStateChanged += Instance_PlayStateChanged;

            if (BackgroundAudioPlayer.Instance.PlayerState != PlayState.Playing) {
                BackgroundAudioPlayer.Instance.Track = getRandomTrack();
                BackgroundAudioPlayer.Instance.Play();
            }

            Loaded += FrameworkElement_Loaded;
        }

        private void Instance_PlayStateChanged(object sender, EventArgs e) {
            switch (BackgroundAudioPlayer.Instance.PlayerState) {
                case PlayState.Playing:
                    
                    break;

                case PlayState.Paused:
                case PlayState.Stopped:
                    
                    break;
            }

        }

        private void FrameworkElement_Loaded(object sender, RoutedEventArgs e) {
            if (meUFP.CurrentState == MediaElementState.Opening || meUFP.CurrentState == MediaElementState.Playing) {
                return;
            }

            meUFP.Play();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String str) {
            if (PropertyChanged != null) {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(str);
                PropertyChanged(this, e);
            }
        }

        private void LBtnOptions_OnTap(object sender, GestureEventArgs e) { NavigationService.Navigate(new Uri("/OptionsPage.xaml", UriKind.Relative)); }

        private void LBtnNewGame_OnTap(object sender, GestureEventArgs e) { NavigationService.Navigate(new Uri("/NewGamePage.xaml", UriKind.Relative)); }

        private void LBtnAbout_OnTap(object sender, GestureEventArgs e) { NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative)); }

        private void MediaElement_OnMediaEnded(object sender, RoutedEventArgs e) { ((MediaElement)sender).Play(); }
    }
}