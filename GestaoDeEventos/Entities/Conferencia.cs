using GestaoDeEventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public class Conferencia: Evento
    {
        public int Artigos { get; set; }
        public string Idioma { get; set; }
        public List<Coordenador> Coordenadores { get; set; } = new List<Coordenador>();
        public string Tema { get; set; }

        public override void Cancelar()
        {
            Console.WriteLine($"A conferência {Nome} será cancelada.");
        }
        public override void Concluir()
        {
            Console.WriteLine($"A conferência {Nome} será concluída.");
        }
        public override void Iniciar()
        {
            Console.WriteLine($"A conferência {Nome} será iniciada.");
        }
        public override void Pausar()
        {
            Console.WriteLine($"A conferência {Nome} será pausada.");
        }
    }

    public class Coordenador()
    {
        public string Nome { get; set; }
        public string Universidade { get; set; }
    }
}
