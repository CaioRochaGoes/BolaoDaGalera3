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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridPaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridClassificacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crudParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(575, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tabelasToolStripMenuItem
			// 
			this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridPaisesToolStripMenuItem,
            this.gridClassificacaoToolStripMenuItem,
            this.crudParticipantesToolStripMenuItem});
			this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
			this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.tabelasToolStripMenuItem.Text = "Tabelas";
			// 
			// gridPaisesToolStripMenuItem
			// 
			this.gridPaisesToolStripMenuItem.Name = "gridPaisesToolStripMenuItem";
			this.gridPaisesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.gridPaisesToolStripMenuItem.Text = "Grid Paises";
			this.gridPaisesToolStripMenuItem.Click += new System.EventHandler(this.gridPaisesToolStripMenuItem_Click);
			// 
			// gridClassificacaoToolStripMenuItem
			// 
			this.gridClassificacaoToolStripMenuItem.Name = "gridClassificacaoToolStripMenuItem";
			this.gridClassificacaoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.gridClassificacaoToolStripMenuItem.Text = "Grid Classificacao";
			this.gridClassificacaoToolStripMenuItem.Click += new System.EventHandler(this.gridClassificacaoToolStripMenuItem_Click);
			// 
			// crudParticipantesToolStripMenuItem
			// 
			this.crudParticipantesToolStripMenuItem.Name = "crudParticipantesToolStripMenuItem";
			this.crudParticipantesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.crudParticipantesToolStripMenuItem.Text = "Crud Participantes";
			this.crudParticipantesToolStripMenuItem.Click += new System.EventHandler(this.crudParticipantesToolStripMenuItem_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(575, 497);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Home";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridPaisesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridClassificacaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crudParticipantesToolStripMenuItem;
	}
}