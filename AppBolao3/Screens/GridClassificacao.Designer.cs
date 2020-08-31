namespace AppBolao3.Screens
{
	partial class GridClassificacao
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bolaoDataSet = new AppBolao3.bolaoDataSet();
			this.bolaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dgvClassificacao = new System.Windows.Forms.DataGridView();
			this.tbparticipantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bolaoDataSet1 = new AppBolao3.bolaoDataSet1();
			this.tb_participantesTableAdapter = new AppBolao3.bolaoDataSet1TableAdapters.tb_participantesTableAdapter();
			this.btnAtualizarTabela = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbparticipantesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// bolaoDataSet
			// 
			this.bolaoDataSet.DataSetName = "bolaoDataSet";
			this.bolaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bolaoDataSetBindingSource
			// 
			this.bolaoDataSetBindingSource.DataSource = this.bolaoDataSet;
			this.bolaoDataSetBindingSource.Position = 0;
			// 
			// dgvClassificacao
			// 
			this.dgvClassificacao.AllowUserToAddRows = false;
			this.dgvClassificacao.AllowUserToDeleteRows = false;
			this.dgvClassificacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvClassificacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvClassificacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			this.dgvClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvClassificacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dgvClassificacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvClassificacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvClassificacao.ColumnHeadersHeight = 30;
			this.dgvClassificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvClassificacao.EnableHeadersVisualStyles = false;
			this.dgvClassificacao.Location = new System.Drawing.Point(23, 29);
			this.dgvClassificacao.Name = "dgvClassificacao";
			this.dgvClassificacao.ReadOnly = true;
			this.dgvClassificacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvClassificacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvClassificacao.RowHeadersVisible = false;
			this.dgvClassificacao.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvClassificacao.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvClassificacao.RowTemplate.Height = 24;
			this.dgvClassificacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvClassificacao.Size = new System.Drawing.Size(539, 395);
			this.dgvClassificacao.TabIndex = 0;
			// 
			// tbparticipantesBindingSource
			// 
			this.tbparticipantesBindingSource.DataMember = "tb_participantes";
			this.tbparticipantesBindingSource.DataSource = this.bolaoDataSet1;
			// 
			// bolaoDataSet1
			// 
			this.bolaoDataSet1.DataSetName = "bolaoDataSet1";
			this.bolaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tb_participantesTableAdapter
			// 
			this.tb_participantesTableAdapter.ClearBeforeFill = true;
			// 
			// btnAtualizarTabela
			// 
			this.btnAtualizarTabela.Location = new System.Drawing.Point(626, 44);
			this.btnAtualizarTabela.Name = "btnAtualizarTabela";
			this.btnAtualizarTabela.Size = new System.Drawing.Size(141, 52);
			this.btnAtualizarTabela.TabIndex = 1;
			this.btnAtualizarTabela.Text = "Atualizar Tabela";
			this.btnAtualizarTabela.UseVisualStyleBackColor = true;
			this.btnAtualizarTabela.Click += new System.EventHandler(this.btnAtualizarTabela_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(691, 398);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(97, 40);
			this.btnVoltar.TabIndex = 2;
			this.btnVoltar.Text = "Voltar Home";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// GridClassificacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnAtualizarTabela);
			this.Controls.Add(this.dgvClassificacao);
			this.Name = "GridClassificacao";
			this.Text = "GridClassificacao";
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbparticipantesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource bolaoDataSetBindingSource;
		private bolaoDataSet bolaoDataSet;
		private System.Windows.Forms.DataGridView dgvClassificacao;
		private bolaoDataSet1 bolaoDataSet1;
		private System.Windows.Forms.BindingSource tbparticipantesBindingSource;
		private bolaoDataSet1TableAdapters.tb_participantesTableAdapter tb_participantesTableAdapter;
		private System.Windows.Forms.Button btnAtualizarTabela;
		private System.Windows.Forms.Button btnVoltar;
	}
}