using System.Diagnostics;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace KcMvvm.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _email;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(() => FirstName); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(() => LastName); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; RaisePropertyChanged(() => Email);}
        }

        private MvxCommand _registerCommand;

        public IMvxCommand RegisterCommand
        {
            get
            {
                _registerCommand = _registerCommand ?? new MvxCommand(Register);
                return _registerCommand;
            }
        }

        private void Register()
        {
            Debug.WriteLine(string.Format("Register Command Executed with {0},{1},{2}",FirstName,LastName,Email));
        }
    }
}