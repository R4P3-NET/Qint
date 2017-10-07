using System;
using System.ComponentModel;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;

namespace Qint.Desktop
{
	public class MainForm : Form
	{
		public SampleData data;

		public MainForm()
		{
			XamlReader.Load(this);

			//var nav = new Navigation();

			Icon = new Icon("Qint.ico");

			var ServerTreeToggle = (ImageView)FindChild("ServerTreeToggle");
			ServerTreeToggle.Image = new Bitmap(new Bitmap("Tree.png"), ServerTreeToggle.Width, ServerTreeToggle.Height, ImageInterpolation.High);

			var item = FindChild("ChannelView");
			item.DataContext = data = new SampleData();
		}

		public void ToggleTreeView(object sender, MouseEventArgs args)
		{
			var elem = FindChild("ServerTree");
			elem.Visible = !elem.Visible;
		}

		public void Modify(object sender, EventArgs args)
		{
			data.Modify();
		}
	}

	public class SampleData : INotifyPropertyChanged
	{
		public string Text { get; set; }
		public int Number { get; set; }

		public SampleData()
		{
			Text = "";
			Number = 42;
		}

		public void Modify()
		{
			Text = Text + " a";
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
			Number++;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
