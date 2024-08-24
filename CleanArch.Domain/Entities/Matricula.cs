using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Matricula
    {
        public Guid Id { get; private set; }
        public DateTime DataMatricula { get; private set; }
        public string Status { get; private set; }
        public Guid AlunoId { get; private set; }
        public Aluno Aluno { get; private set; }
        public Guid CursoId { get; private set; }
        public Curso Curso { get; private set; }

        public Matricula() { }
        public Matricula(Guid id, DateTime dataMatricula, Aluno aluno, Curso curso)
        {
            Id = id;
            DataMatricula = dataMatricula;
            Aluno = aluno;
            AlunoId = aluno.Id;
            Curso = curso;
            CursoId = curso.Id;
            Status = "Ativa";
        }

        public void ConcluirMatricula(Curso curso, Aluno aluno)
        {
            if (curso == null || aluno == null)
            {
                throw new InvalidOperationException("Curso ou aluno não estão definidos.");
            }

            if (curso.Matriculas.Count >= 30 || !aluno.Ativo)
            {
                throw new InvalidOperationException("Não é possível concluir a matrícula.");
            }

            Status = "Concluída";
        }

        public void CancelarMatricula()
        {
            Status = "Cancelada";
        }
    }
}
