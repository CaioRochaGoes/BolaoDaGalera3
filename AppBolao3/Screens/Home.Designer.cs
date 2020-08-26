namespace AppBolao3.Screens
{
	partial class Home
	{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.MenuSup = new System.Windows.Forms.MenuStrip();
			this.classificacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CbolaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tabelasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.participantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.outrasOpcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSup.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuSup
			// 
			this.MenuSup.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuSup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MenuSup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classificacaoToolStripMenuItem,
            this.configsToolStripMenuItem1,
            this.tabelasToolStripMenuItem1,
            this.participantesToolStripMenuItem1,
            this.outrasOpcoesToolStripMenuItem});
			this.MenuSup.Location = new System.Drawing.Point(0, 0);
			this.MenuSup.Name = "MenuSup";
			this.MenuSup.Size = new System.Drawing.Size(575, 28);
			this.MenuSup.TabIndex = 3;
			this.MenuSup.Text = "MenuSup";
			// 
			// classificacaoToolStripMenuItem
			// 
			this.classificacaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CbolaoToolStripMenuItem});
			this.classificacaoToolStripMenuItem.Name = "classificacaoToolStripMenuItem";
			this.classificacaoToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.classificacaoToolStripMenuItem.Text = "Classificação";
			// 
			// CbolaoToolStripMenuItem
			// 
			this.CbolaoToolStripMenuItem.Name = "CbolaoToolStripMenuItem";
			this.CbolaoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.CbolaoToolStripMenuItem.Text = "Bolão";
			this.CbolaoToolStripMenuItem.Click += new System.EventHandler(this.CbolaoToolStripMenuItem_Click);
			// 
			// configsToolStripMenuItem1
			// 
			this.configsToolStripMenuItem1.Name = "configsToolStripMenuItem1";
			this.configsToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
			this.configsToolStripMenuItem1.Text = "Configs";
			// 
			// tabelasToolStripMenuItem1
			// 
			this.tabelasToolStripMenuItem1.Name = "tabelasToolStripMenuItem1";
			this.tabelasToolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
			this.tabelasToolStripMenuItem1.Text = "Tabelas";
			// 
			// participantesToolStripMenuItem1
			// 
			this.participantesToolStripMenuItem1.Name = "participantesToolStripMenuItem1";
			this.participantesToolStripMenuItem1.Size = new System.Drawing.Size(107, 24);
			this.participantesToolStripMenuItem1.Text = "Participantes";
			// 
			// outrasOpcoesToolStripMenuItem
			// 
			this.outrasOpcoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
			this.outrasOpcoesToolStripMenuItem.Name = "outrasOpcoesToolStripMenuItem";
			this.outrasOpcoesToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
			this.outrasOpcoesToolStripMenuItem.Text = "Outras Opções";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(575, 497);
			this.Controls.Add(this.MenuSup);
			this.DoubleBuffered = true;
			this.Enabled = false;
			this.Name = "Home";
			this.Text = "Home";
			this.MenuSup.ResumeLayout(false);
			this.MenuSup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem configsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem outrasOpcoesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem classificacaoToolStripMenuItem;
		public System.Windows.Forms.MenuStrip MenuSup;
		public System.Windows.Forms.ToolStripMenuItem CbolaoToolStripMenuItem;
	}
}