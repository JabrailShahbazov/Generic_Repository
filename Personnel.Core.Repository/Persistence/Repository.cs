using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Personnel.Core.Repository.Repositories;

namespace Personnel.Core.Repository.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(DbContext context)
        {
            this._context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);

        }

        public TEntity Get(int Id)
        {
            return _dbSet.Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Remove(int Id)
        {
            _dbSet.Remove(Get(Id));
        }

        public void RenoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange();
        }
    }
}
