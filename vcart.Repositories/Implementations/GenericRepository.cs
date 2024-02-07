using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Repositories.Interfaces;

namespace vcart.Repositories.Implementations
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        DbContext _context;
        DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context, DbSet<TEntity> dbSet)
        {
            _context = context;
            dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity FindById(object id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
