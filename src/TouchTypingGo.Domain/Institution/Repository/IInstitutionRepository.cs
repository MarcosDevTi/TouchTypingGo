using System;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Institution.Repository
{
    public interface IInstitutionRepository : IRepository<Institution>
    {
        Institution GetByIdWithAddress(Guid id);
    }
}
