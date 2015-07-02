using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using KcMvvm.Core.Commands;
using ReactiveUI;
using KcMvvm.Core._base;

namespace KcMvvm.Core
{
    public abstract class KcViewModel : MvxViewModel, IKcViewModel
    {
        private KcCommandFactory _commandFactory;

        protected KcViewModel()
        {
            _commandFactory = new KcCommandFactory();
        }

        public IMvxCommand CreateCommand(IMvxCommand command)
        {
            return _commandFactory.CreateCommand(command);
        }

        public IMvxCommand GetCommand<T>()
        {
            return _commandFactory.GetCommand<T>();
        }

        public override void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            base.RaisePropertyChanged(changedArgs);
        }

        public virtual void ShowViewModel<T>()
            where T : KcViewModel
        {
            base.ShowViewModel<T>();
        }

    }
    
}
