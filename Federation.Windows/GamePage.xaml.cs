using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Federation.WindowsUniversal.Models;

namespace Federation.WindowsUniversal {
    public partial class GamePage : Page {
        private GameModel viewModel {
            get { return (GameModel) DataContext; }
        }
        
        public GamePage() {
            InitializeComponent();

            DataContext = new GameModel();
        }

        private void LBtnNextTurn_OnTap(object sender, TappedRoutedEventArgs tappedRoutedEventArgs) { viewModel.NextTurn(); }
        
        public void Connect(int connectionId, object target)
        {
               
        }
    }
}