﻿using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Interface;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain;
using System.Collections.Generic;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        //private readonly IBaseRepository<Aluno> baseRepository;
        private readonly IAlunoRepository _repo;

        public AlunoController(IAlunoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _repo.SelecionarTudo();
        }

        /// <summary>
        /// AQUI ESTA O SEU XML
        /// </summary>
        /// <param name="id"> O parâmetro id do aluno necessário</param>
        /// <returns></returns>
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