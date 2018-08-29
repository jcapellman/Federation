using System;
using System.Windows.Input;

namespace Federation.UWP.Commands
{
    public class DelegateCommand : ICommand

    {

        private Action<object> execute;

        private Func<object, bool> canExecute;



        public DelegateCommand(Action<object> execute)

        {

            this.execute = execute;

            this.canExecute = (x) => { return true; };

        }

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)

        {

            this.execute = execute;

            this.canExecute = canExecute;

        }

        public bool CanExecute(object parameter)

        {

            return canExecute(parameter);

        }



        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()

        {

            if (CanExecuteChanged != null)

            {

                CanExecuteChanged(this, EventArgs.Empty);

            }

        }

        public void Execute(object parameter)

        {

            execute(parameter);

        }

    }
}