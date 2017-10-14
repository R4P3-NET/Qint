using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Qint.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qint
{
	[ContentProperty("Text")]
	public class TranslateExtension : IMarkupExtension
	{
		readonly CultureInfo ci;
		const string ResourceId = "Qint.Resources.Localization";

		private static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId
																												  , typeof(TranslateExtension).GetTypeInfo().Assembly));

		public TranslateExtension()
		{
			if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android)
			{
				ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
			}
		}

		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Text == null)
				return "";

			var translation = ResMgr.Value.GetString(Text, ci);

			if (translation == null)
			{
#if DEBUG
				throw new ArgumentException(
					String.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId, ci.Name),
					"Text");
#else
                translation = Text; // returns the key, which GETS DISPLAYED TO THE USER
#endif
			}
			return translation;
		}
	}
}
