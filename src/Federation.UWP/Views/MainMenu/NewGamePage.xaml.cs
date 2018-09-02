using System.Linq;

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
                var item = new RaceSelectionItemControl
                {
                    SelectedRace = race
                };

                item.Tapped += raceSelectionItemControl_Tapped;

                ugRaces.Children.Add(item);
            }

            ViewModel.SetRace(ExtensionMethods.RaceList.FirstOrDefault());
        }

        private void raceSelectionItemControl_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var selectedItem = (RaceSelectionItemControl) sender;

            foreach (var item in ugRaces.Children.Where(a => a != sender))
            {
                ((RaceSelectionItemControl) item).Toggled = false;
            }

            ViewModel.SetRace(selectedItem.SelectedRace);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), ViewModel.BuildGameObject());
        }
    }
}