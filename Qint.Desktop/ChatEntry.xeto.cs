using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Serialization.Xaml;

namespace Qint.Desktop
{	
	public class ChatEntry : Panel
	{	
		public ChatEntry()
		{
			XamlReader.Load(this);
		}
	}
}
