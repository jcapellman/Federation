using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Federation.UWP.Views.MainMenu;

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
            Frame.Navigate(typeof(NewGamePage));
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoadGamePage));
        }

        private void btnOptions_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OptionsPage));
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }
    }
}