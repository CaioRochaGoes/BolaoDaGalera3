namespace AppBolao3.Screens
{
	partial class GridPaises
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvPais = new System.Windows.Forms.DataGridView();
			this.btnAtualizarTabela = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPais
			// 
			this.dgvPais.AllowUserToAddRows = false;
			this.dgvPais.AllowUserToDeleteRows = false;
			this.dgvPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			this.dgvPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dgvPais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPais.ColumnHeadersHeight = 30;
			this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvPais.EnableHeadersVisualStyles = false;
			this.dgvPais.Location = new System.Drawing.Point(32, 28);
			this.dgvPais.Name = "dgvPais";
			this.dgvPais.ReadOnly = true;
			this.dgvPais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPais.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPais.RowHeadersVisible = false;
			this.dgvPais.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvPais.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPais.RowTemplate.Height = 24;
			this.dgvPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPais.Size = new System.Drawing.Size(824, 484);
			this.dgvPais.TabIndex = 1;
			// 
			// btnAtualizarTabela
			// 
			this.btnAtualizarTabela.Location = new System.Drawing.Point(884, 37);
			this.btnAtualizarTabela.Name = "btnAtualizarTabela";
			this.btnAtualizarTabela.Size = new System.Drawing.Size(137, 55);
			this.btnAtualizarTabela.TabIndex = 2;
			this.btnAtualizarTabela.Text = "Atualizar Tabela";
			this.btnAtualizarTabela.UseVisualStyleBackColor = true;
			this.btnAtualizarTabela.Click += new System.EventHandler(this.btnAtualizarTabela_Click);
			// 
			// GridPaises
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(1047, 533);
			this.Controls.Add(this.btnAtualizarTabela);
			this.Controls.Add(this.dgvPais);
			this.Name = "GridPaises";
			this.Text = "GridPaises";
			((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPais;
		private System.Windows.Forms.Button btnAtualizarTabela;
	}
}