using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Mindscape.Raygun4Net;
using KcMvvm.iOS.Containers;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace KcMvvm.iOS
{
	public class Setup : MvxTouchSetup
	{
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
            : base(applicationDelegate, presenter)
		{
		}

        public Setup(AppDelegate appDelegate, UIWindow _window)
            : base(appDelegate, _window)
        {
           
        }

		protected override IMvxApplication CreateApp()
		{
            //RaygunClient.Attach("CQmqhBo0oBBOHzC/KcK8+A==");
			return new KcMvvm.Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxTouchViewsContainer CreateTouchViewsContainer()
        {
            return new KcContainer();
        }
	}
}