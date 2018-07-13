using System.Windows.Input;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Domain.Core.Cqrs
{
    public interface IProcessor
    {
        TResult Process<TResult>(IQuery<TResult> query);
        void Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
