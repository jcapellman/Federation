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
        }

        private void NavigationView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            mainContent.Navigate(ViewModel.GetSelectedPageType((NavigationViewItem)args.SelectedItem));
        }
    }
}