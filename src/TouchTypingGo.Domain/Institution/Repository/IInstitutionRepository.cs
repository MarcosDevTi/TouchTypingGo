using System;
using System.Collections.Generic;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Institution.Repository
{
    public interface IInstitutionRepository : IRepository<Institution>
    {
        Institution GetByIdWithAddress(Guid id);

       
    }
}
