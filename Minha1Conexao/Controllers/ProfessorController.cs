using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Interface;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain;
using System.Collections.Generic;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorRepository _repo;

        public ProfessorController(IProfessorRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Professor> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Professor Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Professor> Post([FromBody] Professor prof)
        {
            _repo.Incluir(prof);

            return _repo.SelecionarTudo();
        }
        [HttpPut]
        public IEnumerable<Professor> Put([FromBody] Professor prof)
        {
            _repo.Alterar(prof);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Professor> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}