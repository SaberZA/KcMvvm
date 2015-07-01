using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using KcMvvm.Core;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.ViewModels;

namespace KcMvvm.iOS
{
    public abstract class KcViewController<T> : MvxViewController<T> 
        where T : KcViewModel
    {
        public KcViewController() : base()
        {}

        public KcViewController(IntPtr handle) : base(handle)
        {}

        protected MvxFluentBindingDescriptionSet<KcViewController<T>, T> CreateBindingSetKc<MvxViewController, MvxViewModel>()
        {
            return this.CreateBindingSet<KcViewController<T>, T>();
        }
    }
}