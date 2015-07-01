using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Plugins.Messenger;
using KcMvvm.Core.ViewModels;
using KcMvvm.Core.ViewModels.LoginViewModel;

namespace KcMvvm.Droid.Views
{
    [Activity(Label = "LoginView")]
    public class LoginView : KcActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);

            ViewModel.LoggedIn += LoggedIn;
        }

        private void LoggedIn()
        {
            ShowToastMessage("Logged in", ToastLength.Short);
        }
    }
}