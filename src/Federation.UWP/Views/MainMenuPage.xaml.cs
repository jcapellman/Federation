using Windows.UI.Xaml.Controls;

using Federation.UWP.ViewModel;

namespace Federation.UWP.Views
{
    public sealed partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();

            DataContext = new MainMenuPageViewModel();
        }
    }
}