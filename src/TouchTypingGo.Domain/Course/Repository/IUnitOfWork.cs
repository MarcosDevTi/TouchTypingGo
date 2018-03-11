using System;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
