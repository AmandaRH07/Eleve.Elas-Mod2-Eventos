
using Eventos.Domain.Participantes;
using Eventos.Eventos;

var dataWorkShop = new DateTime(2024, 07, 01, 14, 00, 00);

var palestrante = new ParticipantePalestrante();
palestrante.AgendaParticipante(dataWorkShop);

var espectador1 = new ParticipanteEspectador();
espectador1.AgendaParticipante(dataWorkShop);

var workShop = new Workshop("Modulos avançados de C#", dataWorkShop, "Zoom", 100);
workShop.Iniciar(new TimeSpan(14, 00, 00), new List<ParticipanteEspectador> { espectador1 },  new List<ParticipantePalestrante> { palestrante });