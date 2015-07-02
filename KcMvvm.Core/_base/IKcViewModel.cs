using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace KcMvvm.Core._base
{
    public interface IKcViewModel
    {
        IMvxCommand CreateCommand(IMvxCommand command);
        IMvxCommand GetCommand<T>();

        void RaisePropertyChanged(PropertyChangedEventArgs changedArgs);
        void ShowViewModel<T>() where T : KcViewModel;
    }
}
