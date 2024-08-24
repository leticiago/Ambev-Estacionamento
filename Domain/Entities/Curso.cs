using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Curso
    {
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public Guid ProfessorId { get; private set; }
        public Professor Professor { get; private set; }

        private List<Matricula> _matriculas = new List<Matricula>();
        public IReadOnlyCollection<Matricula> Matriculas => _matriculas.AsReadOnly();

       
        public Curso() { }

        
        public Curso(string titulo, string descricao, Professor professor)
        {
            Id = Guid.NewGuid();  
            Titulo = titulo;
            Descricao = descricao;
            SetProfessor(professor);
        }

        public void SetProfessor(Professor professor)
        {
            if (professor == null)
                throw new ArgumentNullException(nameof(professor));

            Professor = professor;
            ProfessorId = professor.Id;
        }

        public void AdicionarMatricula(Matricula matricula)
        {
            if (_matriculas.Count < 30)
            {
                _matriculas.Add(matricula);
            }
            else
            {
                throw new InvalidOperationException("O curso já está com o número máximo de alunos.");
            }
        }
    }
}
