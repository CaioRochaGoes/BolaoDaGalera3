
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBolao3.Screens
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
			
		}
		


		private void btnClassificacao_Click(object sender, EventArgs e)
		{
			GridClassificacao formgridClassificacao = new GridClassificacao();
			Home formHome = new Home();
			formgridClassificacao.Show();
			formHome.Close();


		}

		

		private void CbolaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GridClassificacao formgridClassificacao = new GridClassificacao();
			Home formHome = new Home();
			
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string menssagem = "Deseja mesmo sair da aplicação ?";
			string acao = "FECHAR APLICAÇÂO";
			var resultado = MessageBox.Show(menssagem, acao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resultado == DialogResult.Yes)
			{
				MessageBox.Show("Obrigado por usar aplicação");
				Close();

			}
		}
	}
}
