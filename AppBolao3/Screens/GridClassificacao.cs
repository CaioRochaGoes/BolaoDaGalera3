using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringConnection;

namespace AppBolao3.Screens
{
	public partial class GridClassificacao : Form
	{
		public GridClassificacao()
		{
			InitializeComponent();
		}

		Connection conexao = new Connection();
		MySqlCommand cmd = new MySqlCommand();
		
		MySqlDataAdapter da = new MySqlDataAdapter();
		public String mensagem;

		private void btnAtualizarTabela_Click(object sender, EventArgs e)
		{
			//Comando MySQL
			cmd.CommandText = "SELECT ROW_NUMBER() OVER(ORDER BY nu_pontuacao_partic DESC) AS Posição, TB_PARTICIPANTES.nm_nome AS Nome, TB_PARTICIPANTES.nu_pontuacao_partic As Pontuação FROM TB_PARTICIPANTES;";

			try
			{
				//Conexao Com o Banco
				cmd.Connection = conexao.conectar();

				//Executar Comando SQL
				da.SelectCommand = cmd;

				DataTable dt = new DataTable();

				da.Fill(dt);
				dgvClassificacao.DataSource = dt;

				// Desconectar O Banco
				conexao.desconectar();

				//Mensagemde sucesso
				this.mensagem = "Select Executado Com Sucesso!";
			}
			catch (MySqlException Myex)
			{
				//Mensagem de erro
				this.mensagem = "Erro ao tentar se conectar com o banco de dados";
			}

		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			new Home().Show();

			
			
		}
	}
}
