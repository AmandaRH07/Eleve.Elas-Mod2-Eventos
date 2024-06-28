using Eventos.Domain.Eventos;
using Eventos.Domain.Participantes;

namespace Eventos.Eventos
{
	public class Atividade
	{
		public StatusAtividade StatusAtividade { get; set; }
		public List<ParticipanteEspectador> Espectadores { get; set; }
		public List<ParticipantePalestrante> Palestrantes { get; set; }
		public DateTime Inicio { get; set; }
		public TimeSpan HoraInicio { get; set; }
		public DateTime Final { get; set; }
		public TimeSpan HoraFinal { get; set; }

		public Atividade(StatusAtividade statusAtividade, List<ParticipanteEspectador> espectadores, List<ParticipantePalestrante> palestrantes)
		{
			StatusAtividade = statusAtividade;
			Espectadores = espectadores;
			Palestrantes = palestrantes;
		}

		public Atividade(StatusAtividade statusAtividade, TimeSpan hora)
		{
			StatusAtividade = statusAtividade;
			validaHora(hora);
		}

		public Atividade(StatusAtividade statusAtividade, DateTime dia)
		{
			StatusAtividade = statusAtividade;
			validaDia(dia);
		}

		public Atividade(StatusAtividade statusAtividade, TimeSpan inicio, TimeSpan final)
		{
			StatusAtividade = statusAtividade;
			HoraInicio = inicio;
			HoraFinal = final;
		}

		public void validaHora(TimeSpan hora)
		{
			if (StatusAtividade == StatusAtividade.Iniciada)
			{
				HoraInicio = hora;
			}

			if (StatusAtividade == StatusAtividade.Finalizada)
			{
				HoraFinal = hora;
			}
		}

		public void validaDia(DateTime dia)
		{
			if (StatusAtividade == StatusAtividade.Iniciada)
			{
				Inicio = dia;
			}

			if (StatusAtividade == StatusAtividade.Finalizada)
			{
				Final = dia;
			}
		}
	}
}
