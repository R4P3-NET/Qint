using System.Globalization;
namespace Qint.Resources
{
    public interface ILocalize
    {
		CultureInfo GetCurrentCultureInfo();
		void SetLocale(CultureInfo ci);
    }
}
