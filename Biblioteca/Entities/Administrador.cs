using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    public class Administrador
    {
        private long ID { get; set; }
        internal void Gerenciar()
        {
            Console.WriteLine("Gerenciamento da biblioteca");
        }

        protected string ObterInformacoes(long id)
        {
            return $"ID do Administrador: {id}";
        }
    }
}
