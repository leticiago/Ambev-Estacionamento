using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Enum;
using Zoologico.Interfaces;

namespace Zoologico
{
    public class Peixe : Animal, INadar
    {
        public Nadadeira? Nadadeira { get; set; }

        public TipoPeixe Tipo { get;set; }
        public int LimiteProfundidade { get; set; }

        public Peixe(string nome, string cor, int limiteProfundidade) : base(nome, cor)
        {
            LimiteProfundidade = limiteProfundidade;
        }

        public void Descer(int metros)
        {
            Console.WriteLine($"O peixe {NomePopular} esta subindo {metros} metros.");
        }

        public void Subir(int metros)
        {
            Console.WriteLine($"O peixe {NomePopular} esta descendo {metros} metros.");
        }
    }

    public class Nadadeira
    {
        public string? Forma { get; set; }
        public Tamanho Tamanho { get; set; }
        public string? Posicao { get; set; }
    }
}
