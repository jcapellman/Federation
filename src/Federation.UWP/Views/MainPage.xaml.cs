using Windows.UI.Xaml.Controls;

using Federation.UWP.ViewModel;

using NavigationView = Windows.UI.Xaml.Controls.NavigationView;
using NavigationViewSelectionChangedEventArgs = Windows.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs;
using NavigationViewItem = Windows.UI.Xaml.Controls.NavigationViewItem;

namespace Federation.UWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel ViewModel => (MainPageViewModel) DataContext;

        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            nvMain.IsPaneOpen = false;
            
            NavigateToPage("galaxy_map");
        }

        private void NavigateToPage(string tagName)
        {
            var nav = ViewModel.UpdateNavigationItem(tagName);

            if (!nav)
            {
                return;
            }

            mainContent.Navigate(ViewModel.SelectedNavigationItem.PageType);
        }

        private void NavigationView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigateToPage(((NavigationViewItem)args.SelectedItem).Tag.ToString());
        }
    }
}