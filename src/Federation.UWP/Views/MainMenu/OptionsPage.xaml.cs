using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Federation.UWP.Views.MainMenu
{
    public sealed partial class OptionsPage : Page
    {
        public OptionsPage()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}