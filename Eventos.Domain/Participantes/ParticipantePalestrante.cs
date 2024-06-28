namespace Eventos.Domain.Participantes
{
	public class ParticipantePalestrante : Agenda<ParticipantePalestrante>
	{
		public string Nome { get; set; }

		public override string AgendaParticipante(DateTime dataApresentacao)
		{
			return $"Palestra dia {dataApresentacao.Date}, às {dataApresentacao.ToShortTimeString()}";
		}
	}
}
