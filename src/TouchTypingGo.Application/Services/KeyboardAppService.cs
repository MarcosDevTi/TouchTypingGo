using AutoMapper;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course.Commands.Keyboard;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class KeyboardAppService : IKeyboardAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly IKeyboardRepository _keyboardRepository;

        public KeyboardAppService(IBus bus, IMapper mapper, IKeyboardRepository keyboardRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _keyboardRepository = keyboardRepository;
        }
        public void Add(KeyboardViewModel keyboard)
        {
            _bus.SendCommand(new AddKeyboardCommand(
                keyboard.Name, keyboard.Lcid, keyboard.ValHtml, keyboard.KeyboardContent, keyboard.Active));
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new DeleteKeyboardCommand(id));
        }

        public void Dispose()
        {
            _keyboardRepository.Dispose();
        }

        public IEnumerable<KeyboardViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<KeyboardViewModel>>(_keyboardRepository.GetAll());
        }

        public KeyboardViewModel GetById(Guid id)
        {
            return _mapper.Map<KeyboardViewModel>(_keyboardRepository.GetById(id));
        }
    }
}
