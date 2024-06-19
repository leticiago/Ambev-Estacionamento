using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zoologico.Enum;

namespace Zoologico
{
    public class Animal
    {
        public string? NomePopular { get; set; }
        public string? NomeCientifico { get; set; }
        public string? Filo { get; set; }
        public string? Grupo { get; set; }
        public TipoAlimento Alimento { get; set; }
        public bool Vertebrado { get; set; }
        public string? Cor { get; set; }
        public Tamanho Tamanho { get; set; }
        public string? Forma { get; set; }

        public Animal(string nome, string cor)
        {
            NomePopular = nome;
            Cor = cor;
        }
    }
}
