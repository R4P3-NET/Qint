using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;
using System.Collections.ObjectModel;

namespace Qint.Desktop
{
	public class ChatModule : Panel
	{
		ObservableCollection<TextObj> data;
		
#pragma warning disable CS0649
		ListBox chatBox;
		ChatModule chatModule;
#pragma warning restore CS0649

		public ChatModule()
		{
			XamlReader.Load(this);

			data = new ObservableCollection<TextObj> { new TextObj("Hellox"), new TextObj("Theres") };

			chatBox.BindDataContext(c => c.DataStore, (MyModel m) => m.ListItems);
			
			DataContext = new MyModel { ListItems = data };
		}

		public void AddMore(object sender, EventArgs args)
		{
			data.Add(new TextObj("more"));
		}
	}

	class MyModel
	{
		public ObservableCollection<TextObj> ListItems { get; set; }
	}

	class TextObj
	{
		public string Text { get; set; }
		public bool Check { get; set; }

		public TextObj() { }
		public TextObj(string text) { Text = text; }

		public override string ToString() => "To " + Text;
	}
}
