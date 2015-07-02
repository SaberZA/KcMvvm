using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using ObjCRuntime;

namespace KcMvvm.iOS.Containers
{
    public class KcContainer : MvxTouchViewsContainer
    {
        public KcContainer()
        {
        }

        static bool UserInterfaceIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public static bool HasRetina
        {
            get
            {
                if (UIScreen.MainScreen.RespondsToSelector(new Selector("scale")))
                    return (UIScreen.MainScreen.Scale == 2.0);
                else
                    return false;
            }
        }

        protected override IMvxTouchView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            var storyboardName = UserInterfaceIsPhone ? "iPhone" : "iPad";
            var storyboard = UIStoryboard.FromName(storyboardName, null);
            return (IMvxTouchView)storyboard
                .InstantiateViewController(viewType.Name);
        }
    }

}