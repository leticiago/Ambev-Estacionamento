using Application.UseCases.Matriculas.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Matriculas
{
    public class ConcluirMatricula: IConcluirMatricula
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IAlunoRepository _alunoRepository;

        public ConcluirMatricula(IMatriculaRepository matriculaRepository, ICursoRepository cursoRepository, IAlunoRepository alunoRepository)
        {
            _matriculaRepository = matriculaRepository;
            _cursoRepository = cursoRepository;
            _alunoRepository = alunoRepository;
        }

        public void Executar(Guid matriculaId)
        {
            var matricula = _matriculaRepository.ObterPorId(matriculaId);

            if (matricula == null)
            {
                throw new ArgumentException("Matrícula não encontrada.");
            }

            var curso = _cursoRepository.ObterPorId(matricula.CursoId);
            var aluno = _alunoRepository.ObterPorId(matricula.AlunoId);
            matricula.ConcluirMatricula(curso, aluno);
            _matriculaRepository.Atualizar(matricula);
        }
    }
}
