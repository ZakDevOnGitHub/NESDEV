using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace NESDEV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private async void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			OpenFileDialog OFD = new OpenFileDialog();
			OFD.Filter = "6502 Assembly|*.asm";
				OFD.ShowDialog();
			if (OFD.FileName != "")
			{
				Hiddentxt.Text = OFD.FileName;
				FileLabel.Text = $"File: {Path.GetFileName(OFD.FileName)}";
				using (StreamReader SR = new StreamReader(OFD.FileName))
				{
					fastColoredTextBox1.Text = await SR.ReadToEndAsync();
				}
			}
		}

		private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "6502 Assembly | *.asm";
			SFD.ShowDialog();
			using (StreamWriter SW = new StreamWriter(SFD.FileName))
			{
				SW.WriteLineAsync(SFD.FileName);
				MessageBox.Show($"Successfully saved {SFD.FileName}!");
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void configureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Config cfg = new Config();
			cfg.Show();
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private async void runToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProcessStartInfo PSI = new ProcessStartInfo();
			PSI.UseShellExecute = false;
			PSI.CreateNoWindow = false;
			PSI.FileName = Config.Assmblr;
			PSI.WindowStyle = ProcessWindowStyle.Normal;
			PSI.Arguments = Hiddentxt.Text;

			ProcessStartInfo PSI2 = new ProcessStartInfo();
			PSI2.UseShellExecute = false;
			PSI2.CreateNoWindow = false;
			PSI2.FileName = Config.Emulatr;
			PSI2.WindowStyle = ProcessWindowStyle.Normal;
			PSI2.Arguments = $"{Path.GetFileNameWithoutExtension(Hiddentxt.Text)}.nes";

			Process.Start(PSI);
			await Task.Delay(3000);
			Process.Start(PSI2);
		}

		private void languageToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void englishEnglishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fileToolStripMenuItem.Text = "File";
			openToolStripMenuItem.Text = "Open";
			saveToolStripMenuItem.Text = "Save";
			closeToolStripMenuItem.Text = "Close";
			runToolStripMenuItem.Text = "Run";
			configureToolStripMenuItem.Text = "Configure";
			englishEnglishToolStripMenuItem.Text = "English (English)";
			frenchToolStripMenuItem.Text = "French (Français)";
			spanishToolStripMenuItem.Text = "Spanish (Español)";
			arabicToolStripMenuItem.Text = "Arabic (العربية)";
			languageToolStripMenuItem.Text = "Language";
		}

		private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fileToolStripMenuItem.Text = "Fichier";
			openToolStripMenuItem.Text = "Ouvrir";
			saveToolStripMenuItem.Text = "Sauvegarde";
			closeToolStripMenuItem.Text = "Fermer";
			runToolStripMenuItem.Text = "Courir";
			configureToolStripMenuItem.Text = "Configuration";
			englishEnglishToolStripMenuItem.Text = "Anglais (English)";
			frenchToolStripMenuItem.Text = "Français (Français)";
			spanishToolStripMenuItem.Text = "Espagnol (Español)";
			arabicToolStripMenuItem.Text = "Arabe (العربية)";
			languageToolStripMenuItem.Text = "Langue";
		}

		private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fileToolStripMenuItem.Text = "Archivo";
			openToolStripMenuItem.Text = "Abrir";
			saveToolStripMenuItem.Text = "Salvar";
			closeToolStripMenuItem.Text = "Cerrar";
			runToolStripMenuItem.Text = "correr";
			configureToolStripMenuItem.Text = "Config";
			englishEnglishToolStripMenuItem.Text = "Inglés (English)";
			frenchToolStripMenuItem.Text = "Francés (Français)";
			spanishToolStripMenuItem.Text = "Español (Español)";
			arabicToolStripMenuItem.Text = "Árabe (العربية)";
			languageToolStripMenuItem.Text = "Idioma";
		}

		private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fileToolStripMenuItem.Text = "ملف";
			openToolStripMenuItem.Text = "مفتوح";
			saveToolStripMenuItem.Text = "أنقذ";
			closeToolStripMenuItem.Text = "غلق";
			runToolStripMenuItem.Text = "ركض";
			configureToolStripMenuItem.Text = "تكوين";
			englishEnglishToolStripMenuItem.Text = "الإنكليزية (English)";
			frenchToolStripMenuItem.Text = "الفرنسية (Français)";
			spanishToolStripMenuItem.Text = "الإسبانية (Español)";
			arabicToolStripMenuItem.Text = "العربية (العربية)";
			languageToolStripMenuItem.Text = "اللغة";
		}
	}
}
