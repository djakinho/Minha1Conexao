using Minha1Conexao.Data.Interface;
using Minha1Conexao.Domain;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minha1Conexao.Data.Repository
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
