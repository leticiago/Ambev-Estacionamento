using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Application.UseCases.Matriculas.Interfaces;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IMatricularAluno _matricularAluno;
        private readonly IConcluirMatricula _concluirMatricula;

        public MatriculaController(
            IMatriculaRepository matriculaRepository,
            IAlunoRepository alunoRepository,
            ICursoRepository cursoRepository,
            IMatricularAluno matricularAluno,
            IConcluirMatricula concluirMatricula)
        {
            _matriculaRepository = matriculaRepository;
            _alunoRepository = alunoRepository;
            _cursoRepository = cursoRepository;
            _matricularAluno = matricularAluno;
            _concluirMatricula = concluirMatricula;
        }

        [HttpPost]
        public async Task<IActionResult> CriarMatricula(Guid alunoId, Guid cursoId)
        {
            var aluno = _alunoRepository.ObterPorId(alunoId);
            if (aluno == null)
            {
                return NotFound("Aluno não encontrado.");
            }

            var curso = _cursoRepository.ObterPorId(cursoId);
            if (curso == null)
            {
                return NotFound("Curso não encontrado.");
            }

            _matricularAluno.Executar(alunoId, cursoId);

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterMatriculaPorId(Guid id)
        {
            var matricula = _matriculaRepository.ObterPorId(id);
            if (matricula == null)
            {
                return NotFound("Matrícula não encontrada.");
            }

            return Ok(matricula);
        }

        [HttpPut("{id}/concluir")]
        public async Task<IActionResult> ConcluirMatricula(Guid id)
        {
            var matricula = _matriculaRepository.ObterPorId(id);
            if (matricula == null)
            {
                return NotFound("Matrícula não encontrada.");
            }

            try
            {
                _concluirMatricula.Executar(id);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        [HttpPut("{id}/cancelar")]
        public async Task<IActionResult> CancelarMatricula(Guid id)
        {
            var matricula = _matriculaRepository.ObterPorId(id);
            if (matricula == null)
            {
                return NotFound("Matrícula não encontrada.");
            }

            matricula.CancelarMatricula();
            _matriculaRepository.Atualizar(matricula);

            return NoContent();
        }
    }
}
