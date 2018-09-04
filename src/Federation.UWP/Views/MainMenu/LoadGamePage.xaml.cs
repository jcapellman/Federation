using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Federation.UWP.ViewModel.Menu;

namespace Federation.UWP.Views.MainMenu
{
    public sealed partial class LoadGamePage : Page
    {
        private LoadGameViewModel ViewModel => (LoadGameViewModel) DataContext;

        public LoadGamePage()
        {
            InitializeComponent();

            DataContext = new LoadGameViewModel();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainGamePage), ViewModel.SelectedGameItem);
        }
    }
}