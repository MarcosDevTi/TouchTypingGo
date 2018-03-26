using System;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Commands;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IBus
    {
        public static Func<IServiceProvider> ContainerAcessor { get; set; }
        private static IServiceProvider Container => ContainerAcessor();

        public void SendCommand<T>(T theCommand) where T : Command
        {
            Publish(theCommand);
        }

        public void RaiseEvent<T>(T theEvent) where T : Event
        {
            Publish(theEvent);
        }

        private static void Publish<T>(T message) where T : Message
        {
            if (Container == null) return;

            var obj = Container.GetService(message.MessageType.Equals("DomainNotification")
                ? typeof(IDomainNotificationHandler<T>)
                : typeof(IHandler<T>));

            ((IHandler<T>)obj).Handle(message);
        }
    }
}
