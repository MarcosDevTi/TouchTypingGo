using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Entities;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : Entity<TEntity>
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> _courseRepository;

        public AppServiceBase(IBus bus, IMapper mapper, IRepository<TEntity> courseRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public void Add(TEntity courseViewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity courseViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
