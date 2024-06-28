using Eventos.Eventos;

namespace Eventos.Domain.Eventos
{
	public class Evento
	{
		public string Nome { get; set; }
		public DateTime Data { get; set; }
		public string Local { get; set; }
		public int CapacidadeMaxima { get; set; }
		public List<Atividade> Atividades { get; set; }
		public int Nota { get; set; }

		public Evento(string nome, DateTime data, string local, int capacidadeMaxima)
		{
			Nome = nome;
			Data = data;
			Local = local;
			CapacidadeMaxima = capacidadeMaxima;
		}

		public void Iniciar(DateTime diaInicio) { }

		public void Pausar(TimeSpan horaInicio, TimeSpan horaFinal) { }

		public void Concluir(DateTime diaFinal) { }

		public void Cancelar() { }

		public virtual string Avaliacao(int nota)
		{
			Nota = nota;
			return "Avaliação do evento";
		}
	}
}
