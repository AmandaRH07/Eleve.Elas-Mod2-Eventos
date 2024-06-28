
using Eventos.Eventos;

namespace Eventos.Domain.Eventos
{
	public class Conferencia : Evento
	{
		public Conferencia(string nome, DateTime data, string local, int capacidadeMaxima) 
			: base(nome, data, local, capacidadeMaxima)
		{
		}

		public void Iniciar(DateTime diaInicio)
		{
			var atividades = new Atividade(StatusAtividade.Iniciada, diaInicio);
			Atividades.Add(atividades);
		}

		public void Pausar(TimeSpan horaInicio, TimeSpan horaFinal)
		{

		}


		public void Concluir(DateTime diaFinal)
		{
			var atividades = new Atividade(StatusAtividade.Finalizada, diaFinal);
			Atividades.Add(atividades);
		}

		public override string Avaliacao(int estrelas)
		{
			return $"Conferência avaliada com {estrelas} estrelas";
		}

	}
}
