using System;
using TouchTypingGo.Domain.Core.Cqrs.Command;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Domain.Core.Cqrs
{
    public class Processor : IProcessor
    {
        private readonly IServiceProvider _service;

        public Processor(IServiceProvider service) =>
            _service = service;

        public TResult Process<TResult>(IQuery<TResult> query) =>
            GetHandle(typeof(IQueryHandler<,>), query.GetType(), typeof(TResult)).Handle((dynamic)query);

        public void Send<TCommand>(TCommand command) where TCommand : ICommand =>
            GetHandle(typeof(ICommandHandler<>), command.GetType()).Handle(command);

        private dynamic GetHandle(Type handle, params Type[] types) =>
            _service.GetService(handle.MakeGenericType(types));
    }
}
