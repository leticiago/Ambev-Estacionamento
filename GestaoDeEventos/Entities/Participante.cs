using GestaoDeEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public abstract class Participante: IParticipante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Evento> AgendaPersonalizada { get; set; } = new List<Evento>();

        public void AdicionarEventoNaAgenda(Evento evento)
        {
            if (evento.Participantes.Count < evento.CapacidadeMax)
            {
                AgendaPersonalizada.Add(evento);
                evento.Participantes.Add(this);
                Console.WriteLine($"O evento {evento.Nome} foi adicionado à agenda de {Nome}.");
            }
            else
            {
                Console.WriteLine($"O evento {evento.Nome} já atingiu a capacidade máxima.");
            }
        }

        public void ListarAgenda()
        {
            Console.WriteLine($"Agenda de {Nome}:");
            foreach (var evento in AgendaPersonalizada)
            {
                Console.WriteLine($"- {evento.Nome} em {evento.Data}");
            }
        }

        public void RemoverEventoDaAgenda(Evento evento)
        {
            if (AgendaPersonalizada.Remove(evento))
            {
                evento.Participantes.Remove(this);
                Console.WriteLine($"O evento {evento.Nome} foi removido da agenda de {Nome}.");
            }
            else
            {
                Console.WriteLine($"O evento {evento.Nome} não está na agenda de {Nome}.");
            }
        }

        public void ParticiparDeAtividade(Atividade atividade)
        {
            atividade.AdicionarParticipante(this);
        }

        public void AvaliarAtividade(Atividade atividade, int avaliacao)
        {
            atividade.AvaliarAtividade(this, avaliacao);
        }
    }
}
