using Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace PresentationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CriarProfessor([FromBody] Professor novoProfessor)
        {
            if (novoProfessor == null)
            {
                return BadRequest("Dados do professor são obrigatórios.");
            }

            _professorRepository.Adicionar(novoProfessor);
            return CreatedAtAction(nameof(ObterProfessorPorId), new { id = novoProfessor.Id }, novoProfessor);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterProfessorPorId(Guid id)
        {
            var professor = _professorRepository.ObterPorId(id);
            if (professor == null)
            {
                return NotFound("Professor não encontrado.");
            }

            return Ok(professor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarProfessor(Guid id, [FromBody] Professor professorAtualizado)
        {
            if (id != professorAtualizado.Id)
            {
                return BadRequest("ID do professor não corresponde.");
            }

            _professorRepository.Atualizar(professorAtualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirProfessor(Guid id)
        {
            var professor = _professorRepository.ObterPorId(id);
            if (professor == null)
            {
                return NotFound("Professor não encontrado.");
            }

            _professorRepository.Remover(id);
            return NoContent();
        }
    }
}
