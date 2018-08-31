using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using Federation.UWP.Controls;
using Federation.UWP.Common;
using Federation.UWP.ViewModel.Menu;

namespace Federation.UWP.Views.MainMenu
{
    public sealed partial class NewGamePage : Page
    {
        private NewGameViewModel ViewModel => (NewGameViewModel) DataContext;

        public NewGamePage()
        {
            this.InitializeComponent();

            DataContext = new NewGameViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ugRaces.Children.Clear();

            foreach (var race in ExtensionMethods.RaceList)
            {
                ugRaces.Children.Add(new RaceSelectionItemControl
                {
                    SelectedRace = race
                });
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}