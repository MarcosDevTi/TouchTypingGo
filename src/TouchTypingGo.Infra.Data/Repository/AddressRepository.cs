using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Institution;
using TouchTypingGo.Domain.Institution.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(TouchTypingGoContext db, IUser user) : base(db, user)
        {
        }
    }
}
