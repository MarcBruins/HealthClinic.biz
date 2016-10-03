using MvvmCross.Platform;
using MyHealth.Client.Core.ViewModels;
using Xamarin.Forms;

namespace MyHealth.Client.Core
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();

            BindingContext = Mvx.IocConstruct<SettingsViewModel>();
		}
	}
}

