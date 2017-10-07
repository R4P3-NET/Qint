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
		public ChatModule()
		{
			XamlReader.Load(this);

			var collection = new ObservableCollection<TextObj>
			{
				new TextObj { Key = "Row 1", Text = "Row 1", Check = true },
				new TextObj { Key = "Row 2", Text = "Row 2", Check = false }
			};

			var data = new ObservableCollection<string> { "Hello", "There" };

			var listBox = FindChild<ListBox>("ChatEntryList");
			//list.DataStore = collection;

			//list.Items.Add(new ListItem { Text = "Item "});
			//list.Items.Add(new TextObj { Key = "Row 2", Text = "Row 2", Check = false });

			//list.pu
			//list.Bindings.Add(new TextBoxCell())
			//var listBox = new ListBox();
			listBox.BindDataContext(c => c.DataStore, (MyModel m) => m.ListItems);

			// button to change the data context
			var changeDataContext = new Button { Text = "Change Data Context" };
			//changeDataContext.Click += (sender, e) => DataContext = new MyModel { ListItems = new List<string> { "Some", "Other", "Items" } };
			changeDataContext.Click += (sender, e) => { data.Add("more"); };

			Content = new TableLayout
			{
				Rows =
				{
					changeDataContext,
					listBox
				}
			};

			// set initial data context for all controls of the form
			DataContext = new MyModel { ListItems = data };
		}
	}

	class MyModel
	{
		public ObservableCollection<string> ListItems { get; set; }
	}

	class TextObj
	{
		public string Key { get; set; }
		public string Text { get; set; }
		public bool Check { get; set; }
	}
}
