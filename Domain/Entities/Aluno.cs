using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aluno
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }

        private List<Matricula> _matriculas = new List<Matricula>();
        public IReadOnlyCollection<Matricula> Matriculas => _matriculas.AsReadOnly();

        public Aluno(Guid id, string nome, string endereco, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Ativo = true;
        }

        public void AdicionarMatricula(Matricula matricula)
        {
            _matriculas.Add(matricula);
        }

        public void DesativarAluno()
        {
            Ativo = false;
        }
    }
}
