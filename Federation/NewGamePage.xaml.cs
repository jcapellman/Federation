using System;
using System.Windows.Input;

using Federation.Models;

using Microsoft.Phone.Controls;

namespace Federation {
    public partial class NewGamePage : PhoneApplicationPage {

        private NewGameModel viewModel {
            get { return (NewGameModel) DataContext; }
        }

        public NewGamePage() {
            InitializeComponent();

            DataContext = new NewGameModel();
        }

        private void LBtnStart_OnTap(object sender, GestureEventArgs e) { NavigationService.Navigate(new Uri(String.Format("/GamePage.xaml?game={0}", viewModel.CreateGame()), UriKind.Relative)); }
    }
}