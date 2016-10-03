using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MyHealth.Client.Core.ServiceAgents;

namespace MyHealth.Client.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
			Mvx.ConstructAndRegisterSingleton<IMyHealthClient, MyHealthClient> ();
            Mvx.RegisterType<ICurrentUserService, CurrentUserService>();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart(new AppStart());
        }
    }
}