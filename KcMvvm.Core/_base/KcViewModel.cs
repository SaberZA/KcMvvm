using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using KcMvvm.Core.Commands;

namespace KcMvvm.Core._base
{
    public abstract class KcViewModel : MvxViewModel
    {
        private KcCommandFactory _commandFactory;

        protected KcViewModel()
        {
            _commandFactory = new KcCommandFactory();
        }

        protected IMvxCommand CreateCommand(IMvxCommand command)
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
    }
}
