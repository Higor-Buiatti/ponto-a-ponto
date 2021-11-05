using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PaP_APIr.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(int id);
        Task Atualizar(TEntity entity);
        Task<TEntity> ObterPorAtributo(Expression<Func<TEntity, bool>> predicado);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicado);
        Task<int> SaveChanges();
    }
}
