using System;
using Eto.Forms;
using Eto.Drawing;
using WrapperCore;

namespace Qint.Desktop
{ 
	internal static class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			new Application().Run(new MainForm());
		}
	}

	internal class MainForm : Form
	{
		public MainForm()
		{
			this.ClientSize = new Size(600, 400);

			this.Title = "Hello, Eto.Forms: " + WrapperCore.CoreTest.Hi;

			WrapperCore.CoreTest.Log();
		}
	}
}
