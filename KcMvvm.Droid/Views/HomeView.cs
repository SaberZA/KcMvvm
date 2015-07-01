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
using KcMvvm.Core.ViewModels.HomeViewModel;

namespace KcMvvm.Droid.Views
{
    [Activity(Label = "HomeView")]
    public class HomeView : KcActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.HomeView);
        }
    }
}