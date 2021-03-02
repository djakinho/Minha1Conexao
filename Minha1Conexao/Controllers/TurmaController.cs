using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Interface;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain.Model;
using System.Collections.Generic;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepository _repo;

        public TurmaController(ITurmaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Turma Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Turma> Post([FromBody] Turma turma)
        {
            _repo.Incluir(turma);

            return _repo.SelecionarTudo();
        }
        [HttpPut]
        public IEnumerable<Turma> Put([FromBody] Turma turma)
        {
            _repo.Alterar(turma);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Turma> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}