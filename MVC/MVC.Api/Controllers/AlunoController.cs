using Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace MVC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CriarAluno([FromBody] Aluno novoAluno)
        {
            if (novoAluno == null)
            {
                return BadRequest("Dados do aluno são obrigatórios.");
            }

            _alunoRepository.Adicionar(novoAluno);
            return CreatedAtAction(nameof(ObterAlunoPorId), new { id = novoAluno.Id }, novoAluno);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterAlunoPorId(Guid id)
        {
            var aluno = _alunoRepository.ObterPorId(id);
            if (aluno == null)
            {
                return NotFound("Aluno não encontrado.");
            }

            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarAluno(Guid id, [FromBody] Aluno alunoAtualizado)
        {
            if (id != alunoAtualizado.Id)
            {
                return BadRequest("ID do aluno não corresponde.");
            }

            _alunoRepository.Atualizar(alunoAtualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirAluno(Guid id)
        {
            var aluno = _alunoRepository.ObterPorId(id);
            if (aluno == null)
            {
                return NotFound("Aluno não encontrado.");
            }

            _alunoRepository.Remover(id);
            return NoContent();
        }
    }
}
