using GestaoDeEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public class Atividade
    {
        public string Nome { get; set; }
        public DateTime Horario { get; set; } // dividir em inicio e final
        public int Duracao { get; set; }
        public List<Participante> Participantes { get; set; } = new List<Participante>();
        public Dictionary<Participante, int> Avaliacoes { get; set; } = new Dictionary<Participante, int>();

        public void AdicionarParticipante(Participante participante)
        {
            if (!Participantes.Contains(participante))
            {
                Participantes.Add(participante);
                Console.WriteLine($"O participante {participante.Nome} foi adicionado à atividade {Nome}.");
            }
            else
            {
                Console.WriteLine($"O participante {participante.Nome} já está inscrito na atividade {Nome}.");
            }
        }

        public void AvaliarAtividade(Participante participante, int avaliacao)
        {
            if (Participantes.Contains(participante))
            {
                Avaliacoes[participante] = avaliacao;
                Console.WriteLine($"O participante {participante.Nome} avaliou a atividade {Nome} com {avaliacao}.");
            }
            else
            {
                Console.WriteLine($"O participante {participante.Nome} não está inscrito na atividade {Nome}, não pode avaliar.");
            }
        }

        public double ObterMediaAvaliacoes()
        {
            if (Avaliacoes.Count == 0) return 0;
            double soma = 0;
            foreach (var avaliacao in Avaliacoes.Values)
            {
                soma += avaliacao;
            }
            return soma / Avaliacoes.Count;
        }

        public void ListarParticipantes()
        {
            Console.WriteLine($"\nParticipantes da atividade {Nome}:");
            foreach (var participante in Participantes)
            {
                Console.WriteLine($"- {participante.Nome}");
            }
        }
    }
}
