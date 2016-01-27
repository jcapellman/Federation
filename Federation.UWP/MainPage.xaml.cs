using System;
using System.ComponentModel;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Federation.UWP {
    public partial class MainPage : Page, INotifyPropertyChanged {        
        public MainPage() {
            InitializeComponent();

            this.DataContext = this;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String str) {
            if (PropertyChanged != null) {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(str);
                PropertyChanged(this, e);
            }
        }

        private void LBtnOptions_OnTap(object sender, TappedRoutedEventArgs tappedRoutedEventArgs) {
            Frame.Navigate(typeof (OptionsPage));
        }

        private void LBtnNewGame_OnTap(object sender, TappedRoutedEventArgs tappedRoutedEventArgs) { Frame.Navigate(typeof (NewGamePage)); }

        private void LBtnAbout_OnTap(object sender, TappedRoutedEventArgs tappedRoutedEventArgs) { Frame.Navigate(typeof (AboutPage)); }
    }
}