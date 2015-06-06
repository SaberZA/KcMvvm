using System;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace KcMvvm.Core._base
{
    public abstract class KcCommand : IMvxCommand, ICommand
    {
        public void RaiseCanExecuteChanged()
        {

        }

        public abstract void Execute();
        public void Execute(object parameter)
        {
            this.Execute();
        }

        public abstract bool CanExecute();
        public virtual bool CanExecute(object parameter)
        {
            return this.CanExecute();
        }
        
        public event EventHandler CanExecuteChanged;
    }
}
