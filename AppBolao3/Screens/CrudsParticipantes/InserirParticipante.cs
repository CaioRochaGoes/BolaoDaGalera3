using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBolao3.Screens.CrudsParticipantes
{
	public partial class InserirParticipante : Form
	{
		public InserirParticipante()
		{
			InitializeComponent();
		}

		private void txtDescricao_MouseHover(object sender, EventArgs e)
		{
			txtDescricao.Clear();
		}

		private void txtDescricao_MouseClick(object sender, MouseEventArgs e)
		{
			txtDescricao.Clear();
		}

		private void txtNome_MouseHover(object sender, EventArgs e)
		{
			txtNome.Clear();
		}

		private void txtNome_MouseClick(object sender, MouseEventArgs e)
		{
			txtNome.Clear();
		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{

			// Initializes the variables to pass to the MessageBox.Show method.

			string message = "Você realmente deseja apagar todos os campos inseridos ate esse exato momento ? Nenhum dado será salvo no " + 
				"Banco de Dados se essa ação for executada!";

			string titulo = "Apagar Os Campos";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;

			// Displays the MessageBox.

			result = MessageBox.Show(this, message, titulo, buttons,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


			if (result == DialogResult.Yes)
			{
				txtDescricao.Clear();
				txtNome.Clear();
			}
			
		
		}
	}
}
