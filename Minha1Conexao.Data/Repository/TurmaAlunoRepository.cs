using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Domain;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minha1Conexao.Data.Repository
{
    public class TurmaAlunoRepository : BaseRepository<TurmaAluno>
    {
        public List<TurmaAluno> SelecionarTudoCompleto()
        {
            return contexto.TurmaAluno
                .Include(x => x.Aluno)
                .Include(x => x.Turma)
                .ToList();
        }
        public override void Incluir(TurmaAluno entity)
        {
            // colocar regras para inclusão

            base.Incluir(entity);
        }
    }
}
