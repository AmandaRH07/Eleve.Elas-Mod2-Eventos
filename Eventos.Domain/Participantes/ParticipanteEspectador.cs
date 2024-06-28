namespace Eventos.Domain.Participantes
{
	public class ParticipanteEspectador : Agenda<ParticipantePalestrante>
	{
		public string Nome { get; set; }

		public override string AgendaParticipante(DateTime data)
		{
			return $"Palestra dia {data.Date}, às {data.ToShortTimeString()}";
		}
	}
}
