using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Qint.Wrapper;

namespace Qint
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			namedeinerwahl.Text = Core.Hi;
			Core.Log();

		}
	}
}
