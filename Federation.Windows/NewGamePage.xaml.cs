using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Federation.WindowsUniversal.Models;

namespace Federation {
    public partial class NewGamePage : Page {

        private NewGameModel viewModel {
            get { return (NewGameModel) DataContext; }
        }

        public NewGamePage() {
            DataContext = new NewGameModel();
        }

       // private void LBtnStart_OnTap(object sender,  e) { NavigationService.Navigate(new Uri(String.Format("/GamePage.xaml?game={0}", viewModel.CreateGame()), UriKind.Relative)); }
    }
}