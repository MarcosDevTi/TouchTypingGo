using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.LeconResult
{
    public class DeleteLeconResultCommand : LeconResultCommandBase
    {
        public DeleteLeconResultCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
