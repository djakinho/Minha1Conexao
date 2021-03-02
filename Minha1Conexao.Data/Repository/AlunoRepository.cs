using Minha1Conexao.Data.Interface;
using Minha1Conexao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minha1Conexao.Data.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
