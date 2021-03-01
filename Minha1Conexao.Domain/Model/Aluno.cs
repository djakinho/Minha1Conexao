using Minha1Conexao.Domain.Model;
using System.Collections.Generic;

namespace Minha1Conexao.Domain
{
    public class Aluno : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<TurmaAluno> TurmaAluno { get; set; }
    }
}
