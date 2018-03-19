using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TouchTypingGo.Domain.Core.Entities;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected TouchTypingGoContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository(TouchTypingGoContext db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }
        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.FirstOrDefault(t => t.Id == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> prediate)
        {
            return DbSet.Where(prediate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
