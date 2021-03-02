using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Data.Interface
{
    public interface ITurmaProfessorRepository : IBaseRepository<TurmaProfessor>
    {
        List<TurmaProfessor> SelecionarTudoCompleto();
    }
}
