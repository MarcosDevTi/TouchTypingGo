using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Institution;
using TouchTypingGo.Domain.Institution.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class InstitutionRepository : Repository<Institution>, IInstitutionRepository
    {
        private readonly TouchTypingGoContext _db;
        public InstitutionRepository(TouchTypingGoContext db, IUser user) : base(db, user)
        {
            _db = db;
        }

        public Institution GetByIdWithAddress(Guid id)
        {
            return _db.Institutions.Include(x => x.Address).FirstOrDefault(x => x.Id == id);
        }
    }
}
