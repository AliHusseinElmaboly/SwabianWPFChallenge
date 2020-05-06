using System;
using System.Windows.Input;

namespace SwabianWPFChallenge.Commands
{
    public class EquationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action ApplyAction;
        public EquationCommand(Action action)
        {
            ApplyAction = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ApplyAction();
        }
    }
}