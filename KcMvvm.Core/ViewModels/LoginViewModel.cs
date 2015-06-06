using System.Diagnostics;
using Cirrious.MvvmCross.ViewModels;
using KcMvvm.Core.Commands;
using KcMvvm.Core._base;

namespace KcMvvm.Core.ViewModels
{
    public class LoginViewModel : KcViewModel
    {
        public LoginViewModel()
        {
            RegisterCommand = CreateCommand(new RegisterCommand(this));
        }

        #region Properties

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(() => FirstName); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(() => LastName); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; RaisePropertyChanged(() => Email); }
        }

        #endregion

        #region Commands

        public IMvxCommand RegisterCommand { get; set; }

        #endregion



    }
}