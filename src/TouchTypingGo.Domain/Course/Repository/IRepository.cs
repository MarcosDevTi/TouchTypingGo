using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
        void Add(TEntity obj);
        TEntity GetById(Guid? id);
        IReadOnlyList<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(Guid id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
