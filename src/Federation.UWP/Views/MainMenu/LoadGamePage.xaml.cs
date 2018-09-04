using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Federation.UWP.ViewModel.Menu;

namespace Federation.UWP.Views.MainMenu
{
    public sealed partial class LoadGamePage : Page
    {
        public LoadGamePage()
        {
            this.InitializeComponent();

            DataContext = new LoadGameViewModel();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}