using Application.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PresentationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IProfessorRepository _professorRepository;

        public CursoController(ICursoRepository cursoRepository, IProfessorRepository professorRepository)
        {
            _cursoRepository = cursoRepository;
            _professorRepository = professorRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CriarCurso([FromBody] CursoDto novoCursoDto)
        {
            if (novoCursoDto == null)
            {
                return BadRequest("Dados do curso são obrigatórios.");
            }

            var professor = _professorRepository.ObterPorId(novoCursoDto.ProfessorId);
            if (professor == null)
            {
                return NotFound("Professor não encontrado.");
            }

            var novoCurso = new Curso(novoCursoDto.Titulo, novoCursoDto.Descricao, professor);
            _cursoRepository.Adicionar(novoCurso);

            return CreatedAtAction(nameof(ObterCursoPorId), new { id = novoCurso.Id }, novoCurso);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterCursoPorId(Guid id)
        {
            var curso = _cursoRepository.ObterPorId(id);
            if (curso == null)
            {
                return NotFound("Curso não encontrado.");
            }

            return Ok(curso);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarCurso(Guid id, [FromBody] Curso cursoAtualizado)
        {
            if (id != cursoAtualizado.Id)
            {
                return BadRequest("ID do curso não corresponde.");
            }

            _cursoRepository.Atualizar(cursoAtualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirCurso(Guid id)
        {
            var curso = _cursoRepository.ObterPorId(id);
            if (curso == null)
            {
                return NotFound("Curso não encontrado.");
            }

            _cursoRepository.Remover(id);
            return NoContent();
        }
    }
}
