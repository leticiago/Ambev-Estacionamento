using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Enum;
using Zoologico.Interfaces;

namespace Zoologico
{
    public class Mamifero: Animal, INadar, IVoar
    {
        public string? QuantidadePelos { get;set; }
        public Especie Especie { get;set; }
        public Ambiente Ambiente { get;set; }
        public int LimiteProfundidade { get;set; }

        public Mamifero(string nome, string cor, int limiteProfundidade) : base(nome, cor)
        {
            LimiteProfundidade = limiteProfundidade;
        }

        public void Descer(int metros)
        {
            Console.WriteLine($"O mamifero {NomePopular} esta subindo {metros} metros.");
        }

        public void Subir(int metros)
        {
            Console.WriteLine($"O mamifero {NomePopular} esta descendo {metros} metros.");
        }

        public void LevantarVoo()
        {
            Console.WriteLine($"O mamifero {NomePopular} esta levantando voo.");
        }

        public void Pousar()
        {
            Console.WriteLine($"O mamifero {NomePopular} esta pousando.");
        }
    }
}
