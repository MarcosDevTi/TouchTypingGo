using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events.Keyboard;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.Keyboard
{
    public class KeyboardCommandHandler : CommandHandler,
        IHandler<AddKeyboardCommand>,
        IHandler<DeleteKeyboardCommand>
    {
        private readonly IBus _bus;
        private readonly IKeyboardRepository _keyboardRepository;

        public KeyboardCommandHandler(
            IUnitOfWork uow, 
            IBus bus, 
            IDomainNotificationHandler<DomainDotification> notifications, 
            IKeyboardRepository keyboardRepository) : base(uow, bus, notifications)
        {
            _bus = bus;
            _keyboardRepository = keyboardRepository;
        }

        public void Handle(AddKeyboardCommand message)
        {
            var keyboard = Domain.Course.Keyboard.KeyboardFactory.NewKeyboardFactory(
                message.Name, message.Lcid, message.ValHtml, message.KeyboardContent, message.Active);
            _keyboardRepository.Add(keyboard);

            if (!Commit()) return;

            _bus.RaiseEvent(new AddKeyboardEvent(
                message.Name, message.Lcid, message.ValHtml, message.KeyboardContent, message.Active));
        }

        public void Handle(DeleteKeyboardCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
