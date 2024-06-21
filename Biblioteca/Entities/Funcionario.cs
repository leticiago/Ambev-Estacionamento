using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities
{
    public class Funcionario
    {
        protected internal long ID {  get; set; }   
        protected void AdicionarLivro(Livro livro)
        {
            Console.WriteLine($"Adicionando o livro {livro.Titulo} na biblioteca");
        }

        protected internal void RemoverLivro(Livro livro)
        {
            Console.WriteLine($"Remover o livro {livro.Titulo} na biblioteca");
        }

        public void Registrar(Funcionario funcionario)
        {
            Console.WriteLine($"Registrando {funcionario.ID} novo funcionario");
        }
    }
}
