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
            InitializeComponent();

            DataContext = new NewGameViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ugFactions.Children.Clear();

            foreach (var faction in ExtensionMethods.FactionList)
            {
                var item = new FactionSelectionItemControl
                {
                    SelectedFaction = faction
                };

                item.Tapped += factionSelectionItemControl_Tapped;

                ugFactions.Children.Add(item);
            }

            ViewModel.SetFaction(ExtensionMethods.FactionList.FirstOrDefault());
        }

        private void factionSelectionItemControl_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var selectedItem = (FactionSelectionItemControl) sender;

            foreach (var item in ugFactions.Children.Where(a => a != sender))
            {
                ((FactionSelectionItemControl) item).Toggled = false;
            }

            ViewModel.SetFaction(selectedItem.SelectedFaction);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainGamePage), ViewModel.BuildGameObject());
        }
    }
}