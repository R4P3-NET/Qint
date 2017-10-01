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
			
		}
	}
}
