using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WrapperCore
{
	public class Core
	{
		const string libpath = "lib/";

		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		//[DllImport("bindingstest", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		public static extern int get();

        [DllImport("__Internal", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int receive_fn(IntPtr f);//[MarshalAs(UnmanagedType.FunctionPtr)]

		[DllImport("bindingstest", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
#if NET46
		[System.Security.SuppressUnmanagedCodeSecurity]
#endif
		[return: MarshalAs(UnmanagedType.BStr)]
		public static extern string getstr([In] int x);

		public event EventHandler OnNewConenction;
		public event EventHandler OnNewChannel;
		public event EventHandler OnNewClient;

		string ToPascal(string x) => string.Concat(x.Split('_').Where(s => s.Length > 0).Select(s => char.ToUpper(s[0]) + s.Substring(1)));

		string Unquote(string x) => (!x.StartsWith("\"") || !x.EndsWith("\"")) ? x : x.Substring(1, x.Length - 1).Replace("\\n", "\n").Replace("\\\"", "\"").Replace("\\\\", "\\");

		string ToDoc(string x) => $@"\\\<summary>{x}</summary>".Replace("\n", "\n\\\\\\");

		static Core() { }

		public static void Log()
		{
			//Encoding.UTF8.GetString()

			Debug.WriteLine($"{{HI");
			const string regParam = @"(?:;\s*(?<param>\s*(?<pname>\w+):(?<pval>(?:\w+|(?:""(?>[^""]|[""\\n])*"")))\s *,?)*)?";
			var datax = Regex.Match("", @"\s*(?<name>\w+)\s*,\s*(?<type>\w+)\s*?" + regParam);

			var x = datax.Groups["pname"].Captures.Count;

			"".TrimStart('[');
			//var con = new Dto.Connection();
			//con.
		}

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int multiplyWithTwo(int x);

        [MonoPInvokeCallback(typeof(multiplyWithTwo))]
        public static int multiplyWT(int x) 
        {
            return x * 2;
        }
        static multiplyWithTwo mwt = new multiplyWithTwo(multiplyWT);

        public static string Hi {
            get
            {
                Console.WriteLine(Marshal.GetFunctionPointerForDelegate(mwt));
                return "good" + receive_fn(Marshal.GetFunctionPointerForDelegate(mwt));
            }
        }

        public static void Main(String[] args) {
           // Console.WriteL(ine("GOOO" + get() + " " + receive_fn(mwt));
        }
	}

	public class MonoPInvokeCallbackAttribute : System.Attribute
	{
		private Type type;
		public MonoPInvokeCallbackAttribute(Type t) { type = t; }
	}
}
