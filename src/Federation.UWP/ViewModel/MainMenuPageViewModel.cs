using System.Windows.Input;

using Windows.UI.Xaml.Controls;

using Federation.UWP.Commands;
using Federation.UWP.Enums;
using Federation.UWP.Objects.Game;
using Federation.UWP.Views;

namespace Federation.UWP.ViewModel
{
    public class MainMenuPageViewModel : BaseViewModel
    {
        public ICommand NewGameCommand;

        public MainMenuPageViewModel()
        {
            NewGameCommand = new DelegateCommand(NewGame);
        }

        public void NewGame(object param)
        {
            var game = new MainGameItem(GameSize.TINY);

            ((Page)param).Frame.Navigate(typeof(MainMenuPage), game);
        }
    }
}