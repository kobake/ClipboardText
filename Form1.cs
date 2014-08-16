using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardText
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			IDataObject data = Clipboard.GetDataObject();
			if (!data.GetDataPresent(DataFormats.Text))
			{
				this.Close();
				return;
			}
			string str = (string)data.GetData(DataFormats.Text);
			Console.WriteLine(str);
			this.Close();
		}
	}
}
