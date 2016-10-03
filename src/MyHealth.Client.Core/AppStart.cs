
using MvvmCross.Core.ViewModels;

namespace MyHealth.Client.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public void Start(object hint = null)
        {
            ShowViewModel<ViewModels.MainViewModel>();
        }
    }
}
