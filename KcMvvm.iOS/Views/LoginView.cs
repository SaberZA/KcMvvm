
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
        public LoginView(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

    }
}