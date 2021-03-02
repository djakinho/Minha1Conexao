using Minha1Conexao.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Data.Interface
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        void Incluir(T entity);
        void Alterar(T entity);
        T Selecionar(int id);
        List<T> SelecionarTudo();
        void Excluir(int id);
        void Dispose();

    }
}
