using System;
using System.Linq;
using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace KcMvvm.Core.Commands
{
    public class KcCommandFactory : IKcCommandFactory
    {
        private List<IMvxCommand> _commands;

        public KcCommandFactory(List<IMvxCommand> commands = null)
        {
            LoadCommands(commands);
        }

        public void LoadCommands(List<IMvxCommand> commands = null)
        {
            _commands = commands ?? new List<IMvxCommand>();
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