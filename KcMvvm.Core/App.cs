using Cirrious.CrossCore.IoC;
using KcMvvm.Core.ViewModels;
using KcMvvm.Core.ViewModels.LoginViewModel;

namespace KcMvvm.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<LoginViewModel>();

        }
    }
}