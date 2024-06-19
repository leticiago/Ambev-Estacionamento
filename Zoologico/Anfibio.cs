using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interfaces;

namespace Zoologico
{
    public class Anfibio : Animal, INadar
    {
        public bool RespiracaoCutanea { get; set; } 
        public bool RespiracaoPulmonar { get;set; }
        public bool Veneno { get; set; }
        public int LimiteProfundidade { get; set; }

        public Anfibio(string nome, string cor, int limiteProfundidade) : base(nome, cor) {
            LimiteProfundidade = limiteProfundidade;
        }

        public void Descer(int metros)
        {
            Console.WriteLine($"O anfibio {NomePopular} esta subindo {metros} metros.");
        }

        public void Subir(int metros)
        {
            Console.WriteLine($"O anfibio {NomePopular} esta descendo {metros} metros.");
        }
    }
}
