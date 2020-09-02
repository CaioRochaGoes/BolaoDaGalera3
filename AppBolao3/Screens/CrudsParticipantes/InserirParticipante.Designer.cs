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
			this.SuspendLayout();
			// 
			// lblParticipante
			// 
			this.lblParticipante.AutoSize = true;
			this.lblParticipante.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblParticipante.Location = new System.Drawing.Point(1, 20);
			this.lblParticipante.Name = "lblParticipante";
			this.lblParticipante.Size = new System.Drawing.Size(471, 37);
			this.lblParticipante.TabIndex = 0;
			this.lblParticipante.Text = "Adicione Um Novo Participante";
			// 
			// InserirParticipante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(492, 554);
			this.Controls.Add(this.lblParticipante);
			this.Name = "InserirParticipante";
			this.Text = "InserirParticipante";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblParticipante;
	}
}