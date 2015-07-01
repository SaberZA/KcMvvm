using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;

namespace KcMvvm.iOS.Containers
{
    public class MyContainer : MvxTouchViewsContainer
    {
        public MyContainer()
        {
        }

        protected override IMvxTouchView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            var storyboard = UIStoryboard.FromName("iPhone", null);
            return (IMvxTouchView)storyboard
                .InstantiateViewController(viewType.Name);
        }
    }

}