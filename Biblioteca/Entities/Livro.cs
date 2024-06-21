using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    public class Livro
    {
        public string Titulo { get; set; }
        protected string Autor { get;set; }
        internal string ISBN { get; set; }

        public string ObterResumo(string ISBN)
        {
            return $"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}";
        }
    }
}
