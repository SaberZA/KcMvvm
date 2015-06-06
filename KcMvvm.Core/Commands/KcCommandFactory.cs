using System;
using System.Linq;
using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace KcMvvm.Core.Commands
{
    public class KcCommandFactory
    {
        private List<IMvxCommand> _commands;

        public KcCommandFactory()
        {
            _commands = new List<IMvxCommand>();
        }

        public IMvxCommand CreateCommand(IMvxCommand command)
        {
            _commands.Add(command);
            return command;
        }

        public IMvxCommand GetCommand<T>()
        {
            return _commands.FirstOrDefault(c => c.GetType() == typeof (T));
        }
    }
}