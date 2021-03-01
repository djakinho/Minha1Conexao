using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain.Model;
using System.Collections.Generic;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaAlunoController : ControllerBase
    {
        private readonly TurmaAlunoRepository repo;

        public TurmaAlunoController()
        {
            repo = new TurmaAlunoRepository();
        }

        [HttpGet]
        public IEnumerable<TurmaAluno> Get()
        {
            return repo.SelecionarTudoCompleto();
        }

        [HttpGet("{id}")]
        public TurmaAluno Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<TurmaAluno> Post([FromBody] TurmaAluno ta)
        {
            repo.Incluir(ta);

            return repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<TurmaAluno> Put([FromBody] TurmaAluno ta)
        {
            repo.Alterar(ta);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<TurmaAluno> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}