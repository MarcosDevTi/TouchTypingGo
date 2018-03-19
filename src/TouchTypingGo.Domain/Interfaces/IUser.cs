using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace TouchTypingGo.Domain.Interfaces
{
    public interface IUser
    {
        string Name { get; }
        Guid GetUderId();
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
