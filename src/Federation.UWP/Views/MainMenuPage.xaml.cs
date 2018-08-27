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

            Loaded += MainMenuPage_Loaded;
        }

        private void MainMenuPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var game = new MainGameItem(GameSize.TINY);
            
            Frame.Navigate(typeof(MainPage), game);
        }
    }
}