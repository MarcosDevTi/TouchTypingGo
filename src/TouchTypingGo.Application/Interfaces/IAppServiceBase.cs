using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
        void Add(TEntity courseViewModel);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Update(TEntity courseViewModel);
        void Delete(Guid id);
    }
}
