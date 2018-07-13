namespace TouchTypingGo.Domain.Core.Cqrs.Command
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
