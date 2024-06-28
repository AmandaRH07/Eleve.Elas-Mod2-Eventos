using Eventos.Domain.Eventos;
using Eventos.Domain.Participantes;

namespace Eventos.Eventos
{
	public class Workshop : Evento
	{
		public Workshop(string nome, DateTime data, string local, int capacidadeMaxima)
			: base(nome, data, local, capacidadeMaxima)
		{
		}

		public void Iniciar(TimeSpan horaInicio, List<ParticipanteEspectador> espectadors, List<ParticipantePalestrante> palestrantes)
		{
			
			var atividades = new Atividade(StatusAtividade.Iniciada, horaInicio);
			atividades.Espectadores = espectadors;
			atividades.Palestrantes = palestrantes;
			Atividades.Add(atividades);
		}

		public void Pausar(TimeSpan horaInicio, TimeSpan horaFinal)
		{

		}

		public void Concluir(TimeSpan horaFinal)
		{
			var atividades = new Atividade(StatusAtividade.Finalizada, horaFinal);
			Atividades.Add(atividades);
		}

		public override string Avaliacao(int estrelas)
		{
			return $"Workshop avaliado com {estrelas} estrelas";
		}
	}
}
