using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Qint
{
    using Resources;

	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android)
			{
				var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
				Localization.Culture = ci; // set the RESX for resource localization
				DependencyService.Get<ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
			}

			MainPage = new Qint.MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
