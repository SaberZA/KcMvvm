using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using KcMvvm.Core;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace KcMvvm.iOS
{
    public abstract class KcViewController<T> : MvxViewController<T> 
        where T : KcViewModel
    {
        public KcViewController() : base()
        {}

        public KcViewController(IntPtr handle) : base(handle)
        {}

        protected MvxFluentBindingDescriptionSet<TTarget, TSource> CreateBindingSet<TTarget, TSource>() where TTarget : class, IMvxBindingContextOwner
        {
            return this.CreateBindingSet<TTarget, TSource>();
        }
    }
}