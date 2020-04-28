using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandFirst
{
    class GenCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> _action;
        Func<object, bool> _logic;

        public GenCommand(Action<object> action, Func<object, bool> logic)
        {
            _action = action;
            _logic = logic;

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
