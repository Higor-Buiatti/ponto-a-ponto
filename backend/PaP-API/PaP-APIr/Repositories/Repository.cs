using Microsoft.EntityFrameworkCore;
using PaP_API.Data;
using PaP_APIr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PaP_APIr.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public Repository(MeuDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<TEntity> ObterPorId(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }
        public async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }


        public async Task<TEntity> ObterPorAtributo(Expression<Func<TEntity, bool>> predicado)
        {
            return await DbSet.FirstOrDefaultAsync(predicado);
        }


        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public async void Dispose()
        {
            Db?.Dispose();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return await DbSet.AsNoTracking().Where(predicado).ToListAsync();
        }
    }
}
