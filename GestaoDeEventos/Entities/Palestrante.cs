using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Entities
{
    public class Palestrante: Participante
    {
        public string Profissao { get; set; }
        public string Formacao { get;set; }
        public string Sobre { get; set; }
        public string Tema { get; set; }

        public void Palestrar()
        {
            Console.WriteLine($"O palestrante {Nome} vai comecar sua palestra sobre {Tema}.");
        }
    }
}
