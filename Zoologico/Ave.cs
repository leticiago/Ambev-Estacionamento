using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interfaces;

namespace Zoologico
{
    public  class Ave: Animal, IVoar
    {
        public string? FormatoBico { get; set; }
        public bool Voa { get; set; }
        public Ave(string nome, string cor) : base(nome, cor)
        {
        }

        public void LevantarVoo()
        {
            Console.WriteLine($"A ave {NomePopular} esta levantando voo.");
        }

        public void Pousar()
        {
            Console.WriteLine($"A ave {NomePopular} esta pousando.");
        }
    }
}
