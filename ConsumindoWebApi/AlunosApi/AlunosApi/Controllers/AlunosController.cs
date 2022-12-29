using AlunosApi.Models;
using AlunosApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlunosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private IAlunoService _alunoService;

        public AlunosController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Aluno>>> GetAlunos()
        {
            try {
                var alunos = await _alunoService.GetAlunos();
                return Ok(alunos);
            }
            catch (Exception) {

                // return BadRequest("Request Inválido");
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter alunos");
            }
        }

        [HttpGet("AlunosPorNome")]
        public async Task<ActionResult<IAsyncEnumerable<Aluno>>> GetAlunosByName([FromQuery] string nome)
        {
            try {
                var alunos = await _alunoService.GetAlunoByNome(nome);

                if (alunos.Count() == 0) {
                    return NotFound($"O aluno com nome: {nome}, não existe!");
                }

                return Ok(alunos);
            }
            catch (Exception) {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter alunos");
            }
        }

        [HttpGet("{id:int}", Name = "GetAlunoById")]
        public async Task<ActionResult<Aluno>> GetAlunoById(int id)
        {
            try {
                var aluno = await _alunoService.GetAlunoById(id);

                if (aluno == null) {
                    return NotFound($"O aluno com id: {id}, não existe!");
                }
                return Ok(aluno);
            }
            catch (Exception) {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter alunos");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(Aluno aluno)
        {
            try {
                await _alunoService.CreateAluno(aluno);

                return CreatedAtRoute(nameof(GetAlunoById), new { id = aluno.Id }, aluno);
            }
            catch (Exception) {

                return BadRequest("Request inválido");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] Aluno aluno)
        {
            try {
                if (aluno.Id == id) {
                    await _alunoService.UpdateAluno(aluno);
                    return Ok($"Aluno com id: {id} foi atualzado com sucesso!");
                }
                else {
                    return BadRequest("Dados inconsistentes!");
                }

            }
            catch (Exception) {

                return BadRequest("Request inválido");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try {
                var aluno = await _alunoService.GetAlunoById(id);

                if (aluno != null) {
                    await _alunoService.DeleteAluno(aluno);
                    return Ok($"Aluno com id: {id} foi deletado com sucesso!");
                }
                else {
                    return NotFound($"O aluno com id: {id} não existe!");
                }

            }
            catch (Exception) {

                return BadRequest("Request inválido");
            }
        }
    }
}
