using GestaoDeEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public abstract class Evento : IEvento
    {
        public string? Nome { get; set; }
        public DateTime Data { get; set; }
        public string? Local { get; set; }
        public int CapacidadeMax { get; set; }
        public List<Participante> Participantes { get; set; } = new List<Participante>();
        public List<Atividade> Atividades { get; set; } = new List<Atividade>();
        //status do evento

        public void AdicionarAtividade(Atividade atividade)
        {
            Atividades.Add(atividade);
            Console.WriteLine($"A atividade {atividade.Nome} foi adicionada ao evento {Nome}.");
        }

        public void ListarAtividades()
        {
            Console.WriteLine($"\nAtividades do evento {Nome}:");
            foreach (var atividade in Atividades)
            {
                Console.WriteLine($"- {atividade.Nome} às {atividade.Horario}");
            }
        }

        public virtual void Cancelar()
        {
            Console.WriteLine($"O evento {Nome} será cancelado.");
        }

        public virtual void Concluir()
        {
            Console.WriteLine($"O evento {Nome} será concluído.");
        }

        public virtual void Iniciar()
        {
            Console.WriteLine($"O evento {Nome} será iniciado.");
        }

        public virtual void Pausar()
        {
            Console.WriteLine($"O evento {Nome} será pausado.");
        }

        public void AdicionarParticipante(Participante participante)
        {
            if (!Participantes.Contains(participante))
            {
                Participantes.Add(participante);
                participante.AdicionarEventoNaAgenda(this);
                Console.WriteLine($"O participante {participante.Nome} foi adicionado ao evento {Nome}.");
            }
            else
            {
                Console.WriteLine($"O participante {participante.Nome} já está inscrito no evento {Nome}.");
            }
        }

        public void ListarParticipantes()
        {
            Console.WriteLine($"\nParticipantes do evento {Nome}:");
            foreach (var participante in Participantes)
            {
                Console.WriteLine($"- {participante.Nome}");
            }
        }

        static void ListarEventos(List<Evento> eventos)
        {
            Console.WriteLine("\nEventos:");
            foreach (var evento in eventos)
            {
                Console.WriteLine($"- {evento.Nome} em {evento.Data} no {evento.Local}");
            }
        }
    }
}
