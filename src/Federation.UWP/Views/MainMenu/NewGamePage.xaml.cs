using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Federation.UWP.ViewModel.Menu;

namespace Federation.UWP.Views.MainMenu
{
    public sealed partial class NewGamePage : Page
    {
        public NewGamePage()
        {
            this.InitializeComponent();

            DataContext = new NewGameViewModel();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}