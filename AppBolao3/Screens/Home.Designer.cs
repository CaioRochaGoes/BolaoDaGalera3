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
			this.btnClassificacao = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClassificacao
			// 
			this.btnClassificacao.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnClassificacao.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClassificacao.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnClassificacao.Location = new System.Drawing.Point(26, 409);
			this.btnClassificacao.Name = "btnClassificacao";
			this.btnClassificacao.Size = new System.Drawing.Size(166, 52);
			this.btnClassificacao.TabIndex = 0;
			this.btnClassificacao.Text = "Classificação";
			this.btnClassificacao.UseVisualStyleBackColor = false;
			this.btnClassificacao.Click += new System.EventHandler(this.btnClassificacao_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(370, 409);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 52);
			this.button1.TabIndex = 1;
			this.button1.Text = "SAIR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(575, 497);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnClassificacao);
			this.DoubleBuffered = true;
			this.Name = "Home";
			this.Text = "Home";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClassificacao;
		private System.Windows.Forms.Button button1;
	}
}