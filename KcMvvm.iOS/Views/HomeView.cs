
using System;
using System.Drawing;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using KcMvvm.Core.ViewModels.LoginViewModel;
using KcMvvm.Core.ViewModels.HomeViewModel;

namespace KcMvvm.iOS.Views
{
    public partial class HomeView : KcViewController<HomeViewModel>
    {
        public HomeView(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSetKc<HomeView, HomeViewModel>();
            set.Bind(TitleTextView).To(vm => vm.Title);
            set.Apply();
        }

    }
}