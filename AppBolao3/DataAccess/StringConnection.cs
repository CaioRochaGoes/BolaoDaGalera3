using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConnection
{
	public class Connection
	{
		MySqlConnection con = new MySqlConnection();

		//Construtor
		public Connection()
		{
			con.ConnectionString = @"server=127.0.0.1;user id=root;database=bolao;password=colegioplenitude2";
		}

		//Metodo Conectar
		public MySqlConnection conectar()
		{
			//Verificação Status da connection para abrir
			if (con.State == System.Data.ConnectionState.Closed)
			{
				con.Open();

			}
			return con;
		}

		//Metodo Desconectar
		public void desconectar()
		{
			//Verificação Status da connection para fechar close
			if (con.State == System.Data.ConnectionState.Open)
			{
				con.Close();

			}
			
		}
	}
}
