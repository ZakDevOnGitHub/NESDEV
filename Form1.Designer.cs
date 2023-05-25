namespace NESDEV
{
	partial class Form1
	{
		/// THIS CODE SHOULD ONLY BE MODIFIED IF YOU KNOW WHAT YOU'RE DOING!
		/// FAILURE TO FOLLOW THIS MAY RESULT IN CORRUPTION OF THE ENTIRE FORM!
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FileLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Hiddentxt = new System.Windows.Forms.Label();
			this.run = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// fastColoredTextBox1
			// 
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
			this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Location = new System.Drawing.Point(-1, 55);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
			this.fastColoredTextBox1.Size = new System.Drawing.Size(719, 924);
			this.fastColoredTextBox1.TabIndex = 0;
			this.fastColoredTextBox1.Zoom = 100;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.languageToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(717, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.runToolStripMenuItem.Text = "Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
			// 
			// configureToolStripMenuItem
			// 
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.configureToolStripMenuItem.Text = "Configure";
			this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishEnglishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.arabicToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.languageToolStripMenuItem.Text = "Language";
			// 
			// englishEnglishToolStripMenuItem
			// 
			this.englishEnglishToolStripMenuItem.Name = "englishEnglishToolStripMenuItem";
			this.englishEnglishToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.englishEnglishToolStripMenuItem.Text = "English (English)";
			this.englishEnglishToolStripMenuItem.Click += new System.EventHandler(this.englishEnglishToolStripMenuItem_Click);
			// 
			// frenchToolStripMenuItem
			// 
			this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
			this.frenchToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.frenchToolStripMenuItem.Text = "French (Français)";
			this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
			// 
			// spanishToolStripMenuItem
			// 
			this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
			this.spanishToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.spanishToolStripMenuItem.Text = "Spanish (Español)";
			this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
			// 
			// arabicToolStripMenuItem
			// 
			this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
			this.arabicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.arabicToolStripMenuItem.Text = "Arabic (العربية)";
			this.arabicToolStripMenuItem.Click += new System.EventHandler(this.arabicToolStripMenuItem_Click);
			// 
			// FileLabel
			// 
			this.FileLabel.AutoSize = true;
			this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileLabel.ForeColor = System.Drawing.Color.White;
			this.FileLabel.Location = new System.Drawing.Point(12, 35);
			this.FileLabel.Name = "FileLabel";
			this.FileLabel.Size = new System.Drawing.Size(208, 17);
			this.FileLabel.TabIndex = 2;
			this.FileLabel.Text = "Open an ASM file to get started!";
			// 
			// Hiddentxt
			// 
			this.Hiddentxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Hiddentxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hiddentxt.ForeColor = System.Drawing.Color.DarkGray;
			this.Hiddentxt.Location = new System.Drawing.Point(497, 35);
			this.Hiddentxt.Name = "Hiddentxt";
			this.Hiddentxt.Size = new System.Drawing.Size(208, 17);
			this.Hiddentxt.TabIndex = 3;
			// 
			// run
			// 
			this.run.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.run.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.run.ForeColor = System.Drawing.Color.DarkGray;
			this.run.Location = new System.Drawing.Point(246, 35);
			this.run.Name = "run";
			this.run.Size = new System.Drawing.Size(208, 17);
			this.run.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(717, 450);
			this.Controls.Add(this.run);
			this.Controls.Add(this.Hiddentxt);
			this.Controls.Add(this.FileLabel);
			this.Controls.Add(this.fastColoredTextBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "NESDEV";
			((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Label FileLabel;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label Hiddentxt;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishEnglishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
		private System.Windows.Forms.Label run;
	}
}

