using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WrapperCore;

namespace Qint
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			namedeinerwahl.Text = CoreTest.Hi;
			CoreTest.Log();
		}
	}
}
