namespace AppBolao3.Screens
{
	partial class dgvCrudParticipantes
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
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.dgvGridParticipante = new System.Windows.Forms.DataGridView();
			this.btnNovoParticipante = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvGridParticipante)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(695, 24);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(137, 45);
			this.btnAtualizar.TabIndex = 1;
			this.btnAtualizar.Text = "Atualizar Tabela";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// dgvGridParticipante
			// 
			this.dgvGridParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGridParticipante.Location = new System.Drawing.Point(12, 12);
			this.dgvGridParticipante.Name = "dgvGridParticipante";
			this.dgvGridParticipante.RowHeadersWidth = 51;
			this.dgvGridParticipante.RowTemplate.Height = 24;
			this.dgvGridParticipante.Size = new System.Drawing.Size(650, 502);
			this.dgvGridParticipante.TabIndex = 2;
			// 
			// btnNovoParticipante
			// 
			this.btnNovoParticipante.Location = new System.Drawing.Point(695, 115);
			this.btnNovoParticipante.Name = "btnNovoParticipante";
			this.btnNovoParticipante.Size = new System.Drawing.Size(137, 49);
			this.btnNovoParticipante.TabIndex = 3;
			this.btnNovoParticipante.Text = "Inserir Novo";
			this.btnNovoParticipante.UseVisualStyleBackColor = true;
			this.btnNovoParticipante.Click += new System.EventHandler(this.btnNovoParticipante_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(695, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 51);
			this.button2.TabIndex = 4;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dgvCrudParticipantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(863, 526);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnNovoParticipante);
			this.Controls.Add(this.dgvGridParticipante);
			this.Controls.Add(this.btnAtualizar);
			this.Name = "dgvCrudParticipantes";
			this.Text = "CrudParticipantes";
			((System.ComponentModel.ISupportInitialize)(this.dgvGridParticipante)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.DataGridView dgvGridParticipante;
		private System.Windows.Forms.Button btnNovoParticipante;
		private System.Windows.Forms.Button button2;
	}
}