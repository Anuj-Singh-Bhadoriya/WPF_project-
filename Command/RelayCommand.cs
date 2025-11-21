using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.Command
{
    public class RelayCommand : ICommand
    {
        //event EventHandler? ICommand.CanExecuteChanged
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        public event EventHandler CanExecuteChanged;

        private Action DoWork;
        public RelayCommand(Action work)
        {
            DoWork = work;
        }

        bool ICommand.CanExecute(object? parameter)
        {
            return true;
        }

        void ICommand.Execute(object? parameter)
        {
            DoWork();
        }
    }
}
