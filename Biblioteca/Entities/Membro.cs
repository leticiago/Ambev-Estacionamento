using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    public class Membro
    {
        public string Nome { get;set; }
        private long ID { get; set; }
        
        internal void EmprestarLivro(string titulo)
        {
            Console.WriteLine($"{Nome} pegou o livro '{titulo}' emprestado.");
        }
        protected string ObterInfos(long Id)
        {
            return $"Nome: {Nome}, ID do Membro: {Id}";
        }
    }
}
