using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Mindscape.Raygun4Net;
namespace KcMvvm.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {}

        protected override IMvxApplication CreateApp()
        {
            //RaygunClient.Attach("CQmqhBo0oBBOHzC/KcK8+A==");
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}