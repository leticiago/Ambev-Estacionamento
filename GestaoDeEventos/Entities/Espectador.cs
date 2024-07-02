using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public class Espectador : Participante
    {
        public void Ouvir()
        {
            Console.WriteLine($"O expectador {Nome} esta ouvindo.");
        }
    }
}
