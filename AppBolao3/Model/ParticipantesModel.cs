using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBolao3.Model
{
	class ParticipantesModel
	{
		public int IdParticipante  { get; set; }
		public string NomeParticipante { get; set; }
		public string DescricaoParticipante { get; set; }
		public int PontuacaoParticipante { get; set; }
		public string Buraco { get; set; }

		public bool Status { get; set; }

	

	}
}
