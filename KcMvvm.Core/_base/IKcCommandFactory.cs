using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KcMvvm.Core.Commands
{
    public interface IKcCommandFactory
    {
        IMvxCommand CreateCommand(IMvxCommand command);
        IMvxCommand GetCommand<T>();
        void LoadCommands(List<IMvxCommand> commands);
    }
}
