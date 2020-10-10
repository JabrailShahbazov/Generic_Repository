using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Personnel.Core.Repository.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity Get(int Id);
        IEnumerable<TEntity>GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(int Id);
        void RenoveRange(IEnumerable<TEntity> entities);
    }
}
