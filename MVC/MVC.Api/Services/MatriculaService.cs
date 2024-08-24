using Data.Repositories.Interfaces;
using Models.Entities;
using Services.Interface;

namespace Services
{
    public class MatriculaService: IMatriculaService
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IAlunoRepository _alunoRepository;

        public MatriculaService(IMatriculaRepository matriculaRepository, ICursoRepository cursoRepository, IAlunoRepository alunoRepository)
        {
            _matriculaRepository = matriculaRepository;
            _cursoRepository = cursoRepository;
            _alunoRepository = alunoRepository;
        }

        public void MatricularAluno(Guid alunoId, Guid cursoId)
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

        public void ConcluirMatricula(Guid matriculaId)
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
