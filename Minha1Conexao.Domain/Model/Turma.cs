using System.Collections.Generic;

namespace Minha1Conexao.Domain.Model
{
    public class Turma : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<TurmaProfessor> TurmaProfessor { get; set; }
        public List<Aluno> Alunos { get; set; }
    }
}