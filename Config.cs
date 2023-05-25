using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NESDEV
{
	public partial class Config : Form
	{
		public static string Assmblr;
		public static string Emulatr;
		public static string Targetf;

		public Config()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName != "")
			{
				Pth.Text = $"Path: {openFileDialog1.FileName}";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
			if (openFileDialog2.FileName != "")
			{
				Pth2.Text = $"Path: {openFileDialog2.FileName}";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Assmblr = openFileDialog1.FileName;
			Emulatr = openFileDialog2.FileName;
			Targetf = folderBrowserDialog1.SelectedPath;
			MessageBox.Show("Successfully saved paths for the asssembler, emulator, and target folder!");
		}
	}
}
