using System;
using System.Linq;
using System.Linq.Expressions;
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
		public TreeItemCollection tdata;

#pragma warning disable CS0649
		TreeView testTree;
		Control channelView;
		ImageView serverTreeToggle;
#pragma warning restore CS0649

		public MainForm()
		{
			XamlReader.Load(this);

			Icon = new Icon("Qint.ico");

			serverTreeToggle.Image = new Bitmap(new Bitmap("Tree.png"), serverTreeToggle.Width, serverTreeToggle.Height, ImageInterpolation.High);

			channelView.DataContext = data = new SampleData();

			DataContext = tdata = new TreeItemCollection
			{
				new TreeItem() { Text = "HI" },
				new TreeItem() { Text = "HI2" }
			};

			testTree.DataStore = tdata;
			//testTree.BindDataContext(c => c.DataStore, (TreeItemCollection t) => t);
			//testTree.BindDataContext(t => t.DataStore, )

			testTree.BindDataContext(c => c.DataStore, (MyTree m) => m.TreeItems);
		}

		public void ToggleTreeView(object sender, MouseEventArgs args)
		{
			testTree.Visible = !testTree.Visible;
		}

		public void Modify(object sender, EventArgs args)
		{
			data.Modify();

			tdata.Add(new TreeItem() { Text = "HI" });
			testTree.RefreshData();
		}
	}

	class MyTree
	{
		public TreeItemCollection TreeItems { get; set; }
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
