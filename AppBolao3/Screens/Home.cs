
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

		private void gridPaisesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new GridPaises().Show();

		}

		private void gridClassificacaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new GridClassificacao().Show();
		}
	}
}
