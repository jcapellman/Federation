using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Federation.UWP.Enums;
using Federation.UWP.Objects.Game;

namespace Federation.UWP.Views
{
    public sealed partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new MainGameItem(GameSize.TINY));
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnOptions_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}