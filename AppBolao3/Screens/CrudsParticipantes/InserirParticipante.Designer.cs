namespace AppBolao3.Screens.CrudsParticipantes
{
	partial class InserirParticipante
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
			this.lblParticipante = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblDescricao = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.gbParticipantes = new System.Windows.Forms.GroupBox();
			this.rdnNao = new System.Windows.Forms.RadioButton();
			this.rdnSim = new System.Windows.Forms.RadioButton();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimparCampos = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.gbParticipantes.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblParticipante
			// 
			this.lblParticipante.AutoSize = true;
			this.lblParticipante.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblParticipante.Location = new System.Drawing.Point(12, 19);
			this.lblParticipante.Name = "lblParticipante";
			this.lblParticipante.Size = new System.Drawing.Size(471, 37);
			this.lblParticipante.TabIndex = 0;
			this.lblParticipante.Text = "Adicione Um Novo Participante";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(12, 133);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(189, 23);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome Participante:";
			// 
			// lblDescricao
			// 
			this.lblDescricao.AutoSize = true;
			this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescricao.Location = new System.Drawing.Point(12, 215);
			this.lblDescricao.Name = "lblDescricao";
			this.lblDescricao.Size = new System.Drawing.Size(226, 23);
			this.lblDescricao.TabIndex = 2;
			this.lblDescricao.Text = "Descrição Participante:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(207, 135);
			this.txtNome.Multiline = true;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(276, 56);
			this.txtNome.TabIndex = 4;
			this.txtNome.Text = "Nome Participante";
			this.txtNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNome_MouseClick);
			this.txtNome.MouseHover += new System.EventHandler(this.txtNome_MouseHover);
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(19, 253);
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(452, 142);
			this.txtDescricao.TabIndex = 5;
			this.txtDescricao.Text = "Descrição do Participante";
			this.txtDescricao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDescricao_MouseClick);
			this.txtDescricao.MouseHover += new System.EventHandler(this.txtDescricao_MouseHover);
			// 
			// gbParticipantes
			// 
			this.gbParticipantes.Controls.Add(this.rdnNao);
			this.gbParticipantes.Controls.Add(this.rdnSim);
			this.gbParticipantes.Controls.Add(this.lblStatus);
			this.gbParticipantes.Location = new System.Drawing.Point(19, 424);
			this.gbParticipantes.Name = "gbParticipantes";
			this.gbParticipantes.Size = new System.Drawing.Size(464, 118);
			this.gbParticipantes.TabIndex = 9;
			this.gbParticipantes.TabStop = false;
			this.gbParticipantes.Text = "Status";
			// 
			// rdnNao
			// 
			this.rdnNao.AutoSize = true;
			this.rdnNao.Location = new System.Drawing.Point(307, 68);
			this.rdnNao.Name = "rdnNao";
			this.rdnNao.Size = new System.Drawing.Size(55, 21);
			this.rdnNao.TabIndex = 14;
			this.rdnNao.TabStop = true;
			this.rdnNao.Text = "Não";
			this.rdnNao.UseVisualStyleBackColor = true;
			// 
			// rdnSim
			// 
			this.rdnSim.AutoSize = true;
			this.rdnSim.Location = new System.Drawing.Point(307, 41);
			this.rdnSim.Name = "rdnSim";
			this.rdnSim.Size = new System.Drawing.Size(52, 21);
			this.rdnSim.TabIndex = 13;
			this.rdnSim.TabStop = true;
			this.rdnSim.Text = "Sim";
			this.rdnSim.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(51, 41);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(187, 23);
			this.lblStatus.TabIndex = 12;
			this.lblStatus.Text = "Status Participante:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(12, 585);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(141, 45);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// btnLimparCampos
			// 
			this.btnLimparCampos.Location = new System.Drawing.Point(176, 585);
			this.btnLimparCampos.Name = "btnLimparCampos";
			this.btnLimparCampos.Size = new System.Drawing.Size(141, 45);
			this.btnLimparCampos.TabIndex = 11;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = true;
			this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(346, 585);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(141, 45);
			this.btnSair.TabIndex = 12;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// InserirParticipante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(524, 664);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimparCampos);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.gbParticipantes);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblDescricao);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblParticipante);
			this.Name = "InserirParticipante";
			this.Text = "InserirParticipante";
			this.gbParticipantes.ResumeLayout(false);
			this.gbParticipantes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblParticipante;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblDescricao;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.GroupBox gbParticipantes;
		private System.Windows.Forms.RadioButton rdnNao;
		private System.Windows.Forms.RadioButton rdnSim;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimparCampos;
		private System.Windows.Forms.Button btnSair;
	}
}