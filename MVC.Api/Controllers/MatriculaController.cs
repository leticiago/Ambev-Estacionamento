
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace MVC.Api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService _matriculaService;

        public MatriculaController(IMatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }

        [HttpPost("matricular")]
        public IActionResult MatricularAluno(Guid alunoId, Guid cursoId)
        {
            try
            {
                _matriculaService.MatricularAluno(alunoId, cursoId);
                return Ok("Aluno matriculado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}/concluir")]
        public async Task<IActionResult> ConcluirMatricula(Guid id)
        {
            try
            {
                _matriculaService.ConcluirMatricula(id);
                return Ok("Matrícula concluída com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
