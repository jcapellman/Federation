using System.Windows.Input;

using Microsoft.Phone.Controls;

using Federation.Models;

namespace Federation {
    public partial class GamePage : PhoneApplicationPage {
        private GameModel viewModel {
            get { return (GameModel) DataContext; }
        }

        public GamePage() {
            InitializeComponent();

            DataContext = new GameModel();
        }

        private void LBtnNextTurn_OnTap(object sender, GestureEventArgs e) { viewModel.NextTurn(); }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e) {
            rwPause.IsOpen = true;
            e.Cancel = true;
        }
    }
}