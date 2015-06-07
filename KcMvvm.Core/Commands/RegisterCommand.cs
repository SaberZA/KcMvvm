using System.Diagnostics;
using KcMvvm.Core.ViewModels;
using KcMvvm.Core._base;

namespace KcMvvm.Core.Commands
{
    public class RegisterCommand : KcCommand
    {
        private readonly LoginViewModel _loginViewModel;

        public RegisterCommand(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
        }

        public override void Execute()
        {
            Debug.WriteLine("Register Command Executed with {0},{1},{2}", 
                            _loginViewModel.FirstName, 
                            _loginViewModel.LastName, 
                            _loginViewModel.Email);
            _loginViewModel.LoggedIn();
        }

        public override bool CanExecute()
        {
            //invalidate when you aren't allowed to register
            return true;
        }
    }
}