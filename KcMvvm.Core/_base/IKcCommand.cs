using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace KcMvvm.Core._base
{
    public interface IKcCommand : IMvxCommand, ICommand
    {
        new void RaiseCanExecuteChanged();

        new void Execute();
        new void Execute(object parameter);

        new bool CanExecute();
        new bool CanExecute(object parameter);

        new event EventHandler CanExecuteChanged;
    }
}
