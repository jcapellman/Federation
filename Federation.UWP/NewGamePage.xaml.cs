using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

using Federation.UWP.Models;

namespace Federation.UWP {
    public partial class NewGamePage : Page {

        private NewGameModel viewModel => (NewGameModel) DataContext;

        public NewGamePage() {
            DataContext = new NewGameModel();
        }
        
        private void LBtnStart_OnTapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(GamePage), viewModel.CreateGame());
        }
    }
}