
using System;
using System.Drawing;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using KcMvvm.Core.ViewModels.LoginViewModel;

namespace KcMvvm.iOS.Views
{
    public partial class LoginView : KcViewController<LoginViewModel>
    {
        public LoginView()
        { }

        public LoginView(IntPtr handle)
            : base(handle)
        {
        }

        //public new LoginViewModel ViewModel
        //{
        //    get { return (LoginViewModel)base.ViewModel; }
        //    set { base.ViewModel = value; }
        //}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = base.CreateBindingSetKc<LoginView, LoginViewModel>();            
            set.Bind(HomeButton).To(vm => vm.RegisterCommand);
            set.Apply();

            ViewModel.LoggedIn += () =>
            {

            };
        }

    }
}