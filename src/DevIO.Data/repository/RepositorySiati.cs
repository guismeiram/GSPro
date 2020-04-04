using DevIO.Bussines.interfaces;
using DevIO.Bussines.models;
using DevIO.Data.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.repository
{
    public class RepositorySiati<Siati>: IRepositorySiati<Siati> where Siati : Entity,new()
    {
        protected readonly GSProDbContext Db;
        protected readonly DbSet<Siati> DbSet;
        public Siati _siati;
        public RepositorySiati(GSProDbContext db)
        {
            Db = db;
            DbSet = db.Set<Siati>();
        }

        public RepositorySiati()
        {

        }
        public virtual async Task Adicionar(Siati entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(Siati entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task<IEnumerable<Siati>> Buscar(Expression<Func<Siati, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        

        public async Task Remover(Guid id)
        {

            var rem = await DbSet.FindAsync(id);
            DbSet.Remove(rem);
            await SaveChanges();

        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public virtual async Task<Siati> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);

        }

        public virtual async Task<List<Siati>> ObterTodos()
        {
           

            return await DbSet.ToListAsync();


        }

      
    }
}
