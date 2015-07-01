﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace KcMvvm.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        // class-level declarations
        UIWindow _window;            
        //public override UIWindow Window
        //{
        //    get;
        //    set;
        //}

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            // create a new window instance based on the screen size
            _window = new UIWindow(UIScreen.MainScreen.Bounds);
            //var presenter = new MvxTouchViewPresenter(this, Window);

            //var setup = new Setup(this, presenter);
            var setup = new Setup(this, _window);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            // If you have defined a view, add it here:
            // window.RootViewController  = navigationController;

            // make the window visible
            _window.MakeKeyAndVisible();

            return true;
        }
    }
}