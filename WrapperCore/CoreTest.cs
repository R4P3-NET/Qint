using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WrapperCore
{
	public static class CoreTest
	{
		const string libpath = "lib/";

		[DllImport("bindingstest", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		public static extern int get();

		static CoreTest() { }

		public static void Log()
		{
			Debug.WriteLine("HI");
		}

		public static string Hi => "GOOO" + get();
	}
}
