using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Domain.Model
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }


    }
}
