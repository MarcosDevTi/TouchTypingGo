using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.LeconPresentation
{
    public class LeconPresentationDeleteCommand : LeconPresentationCommand
    {
        public LeconPresentationDeleteCommand(Guid id)
        {
            Id = id;
            AggregateId = Id;
        }
    }
}
