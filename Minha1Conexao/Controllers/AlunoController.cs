using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Interface;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain;
using System.Collections.Generic;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlunoController : ControllerBase
    {
        //private readonly IBaseRepository<Aluno> baseRepository;
        private readonly IAlunoRepository _repo;

        public AlunoController(IAlunoRepository repo)
        {
            _repo = repo;
        }
        /// <summary>
        /// Seleciona todos os Alunos
        /// </summary>
        /// <returns>Retorna uma lista de Alunos</returns>
        [ProducesResponseType(400)]
        [HttpGet]
        public IActionResult Get()
        {
            var minhaVar = _repo.SelecionarTudo();
            if (minhaVar == null)
                return NotFound(new { mensagem = "Não foi possível encontrar nenhum Aluno" });
            return Ok(minhaVar);
        }

        /// <summary>
        /// Seleciona o aluno pelo Id
        /// </summary>
        /// <param name="id"> O parâmetro id do aluno necessário</param>
        /// <returns>Retorna o objeto Aluno</returns>
        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] Aluno aluno)
        {
            _repo.Incluir(aluno);

            return _repo.SelecionarTudo();
        }
        [HttpPut("{id}")]
        public IEnumerable<Aluno> Put(int id, [FromBody] Aluno aluno)
        {
            _repo.Alterar(aluno);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Aluno> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}