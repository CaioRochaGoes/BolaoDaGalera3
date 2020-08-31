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
	public partial class GridPaises : Form
	{
		public GridPaises()
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
			cmd.CommandText = "SELECT id_pais AS 'ID Pais' , nm_pais AS Pais, cod_pais AS Sigla FROM TB_PAIS;";


			try { 
					//Conexao Com o Banco
					cmd.Connection = conexao.conectar();

					//Executar Comando SQL
					da.SelectCommand = cmd;

					DataTable dt = new DataTable();

					da.Fill(dt);
					dgvPais.DataSource = dt;

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

		
	}
}
