using MySql.Data.MySqlClient;
using StringConnection;
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
	public partial class dgvCrudParticipantes : Form
	{
		public dgvCrudParticipantes()
		{
			InitializeComponent();
		}

		Connection conexao = new Connection();
		MySqlCommand cmd = new MySqlCommand();

		MySqlDataAdapter da = new MySqlDataAdapter();
		public String mensagem;
		
		
		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			//Comando MySQL
			cmd.CommandText = "SELECT id_participante AS ID , nm_nome AS Nome, txt_descricao AS Descricao FROM TB_PARTICIPANTES;";



			try
			{
				//Conexao Com o Banco
				cmd.Connection = conexao.conectar();

				//Executar Comando SQL
				da.SelectCommand = cmd;

				DataTable dt = new DataTable();

				da.Fill(dt);
				dgvCrudParticipante.DataSource = dt;

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

		private void btnNovoParticipante_Click(object sender, EventArgs e)
		{

		}
	}
}
