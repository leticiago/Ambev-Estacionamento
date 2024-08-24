
using Application.UseCases.Matriculas.Interfaces;
using Domain;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Matriculas
{
    public class MatricularAluno: IMatricularAluno
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IMatriculaRepository _matriculaRepository;

        public MatricularAluno(IAlunoRepository alunoRepository, ICursoRepository cursoRepository, IMatriculaRepository matriculaRepository)
        {
            _alunoRepository = alunoRepository;
            _cursoRepository = cursoRepository;
            _matriculaRepository = matriculaRepository;
        }

        public void Executar(Guid alunoId, Guid cursoId)
        {
            var aluno = _alunoRepository.ObterPorId(alunoId);
            var curso = _cursoRepository.ObterPorId(cursoId);

            if (curso.Matriculas.Count >= 30)
            {
                throw new InvalidOperationException("O curso já está lotado.");
            }

            var matricula = new Matricula(Guid.NewGuid(), DateTime.Now, aluno, curso);
            curso.AdicionarMatricula(matricula);

            _matriculaRepository.Adicionar(matricula);
        }
    }
}
