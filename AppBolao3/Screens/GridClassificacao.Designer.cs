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
			this.bolaoDataSet = new AppBolao3.bolaoDataSet();
			this.bolaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dgvClassificacao = new System.Windows.Forms.DataGridView();
			this.bolaoDataSet1 = new AppBolao3.bolaoDataSet1();
			this.tbparticipantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tb_participantesTableAdapter = new AppBolao3.bolaoDataSet1TableAdapters.tb_participantesTableAdapter();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAtualizarTabela = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbparticipantesBindingSource)).BeginInit();
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
			this.dgvClassificacao.AllowUserToDeleteRows = false;
			this.dgvClassificacao.AutoGenerateColumns = false;
			this.dgvClassificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClassificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Pontos});
			this.dgvClassificacao.DataSource = this.tbparticipantesBindingSource;
			this.dgvClassificacao.Location = new System.Drawing.Point(23, 29);
			this.dgvClassificacao.Name = "dgvClassificacao";
			this.dgvClassificacao.ReadOnly = true;
			this.dgvClassificacao.RowHeadersWidth = 51;
			this.dgvClassificacao.RowTemplate.Height = 24;
			this.dgvClassificacao.Size = new System.Drawing.Size(507, 395);
			this.dgvClassificacao.TabIndex = 0;
			this.dgvClassificacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassificacao_CellContentClick);
			// 
			// bolaoDataSet1
			// 
			this.bolaoDataSet1.DataSetName = "bolaoDataSet1";
			this.bolaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbparticipantesBindingSource
			// 
			this.tbparticipantesBindingSource.DataMember = "tb_participantes";
			this.tbparticipantesBindingSource.DataSource = this.bolaoDataSet1;
			// 
			// tb_participantesTableAdapter
			// 
			this.tb_participantesTableAdapter.ClearBeforeFill = true;
			// 
			// Nome
			// 
			this.Nome.HeaderText = "Nome Participante";
			this.Nome.MinimumWidth = 6;
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			this.Nome.Width = 125;
			// 
			// Pontos
			// 
			this.Pontos.HeaderText = "Total Pontos";
			this.Pontos.MinimumWidth = 6;
			this.Pontos.Name = "Pontos";
			this.Pontos.ReadOnly = true;
			this.Pontos.Width = 125;
			// 
			// btnAtualizarTabela
			// 
			this.btnAtualizarTabela.Location = new System.Drawing.Point(619, 64);
			this.btnAtualizarTabela.Name = "btnAtualizarTabela";
			this.btnAtualizarTabela.Size = new System.Drawing.Size(141, 52);
			this.btnAtualizarTabela.TabIndex = 1;
			this.btnAtualizarTabela.Text = "Atualizar Tabela";
			this.btnAtualizarTabela.UseVisualStyleBackColor = true;
			this.btnAtualizarTabela.Click += new System.EventHandler(this.btnAtualizarTabela_Click);
			// 
			// GridClassificacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAtualizarTabela);
			this.Controls.Add(this.dgvClassificacao);
			this.Name = "GridClassificacao";
			this.Text = "GridClassificacao";
			
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bolaoDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbparticipantesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource bolaoDataSetBindingSource;
		private bolaoDataSet bolaoDataSet;
		private System.Windows.Forms.DataGridView dgvClassificacao;
		private bolaoDataSet1 bolaoDataSet1;
		private System.Windows.Forms.BindingSource tbparticipantesBindingSource;
		private bolaoDataSet1TableAdapters.tb_participantesTableAdapter tb_participantesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pontos;
		private System.Windows.Forms.Button btnAtualizarTabela;
	}
}