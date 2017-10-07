using System;
using Eto.Forms;

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
}
