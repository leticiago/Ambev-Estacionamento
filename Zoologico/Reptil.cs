using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Enum;
using Zoologico.Interfaces;

namespace Zoologico
{
    public class Reptil: Animal, INadar
    {
        public int TemperaturaCorporal { get;set; }
        public Ambiente Ambiente { get;set; }
        public bool Membros { get; set; }
        public int LimiteProfundidade { get; set; }
        public Reptil(string nome,string cor, int limiteProfundidade) : base(nome, cor)
        {
            LimiteProfundidade = limiteProfundidade;
        }

        public void Descer(int metros)
        {
            Console.WriteLine($"O reptil {NomePopular} esta subindo {metros} metros.");
        }

        public void Subir(int metros)
        {
            Console.WriteLine($"O reptil {NomePopular} esta descendo {metros} metros.");
        }
    }
}
