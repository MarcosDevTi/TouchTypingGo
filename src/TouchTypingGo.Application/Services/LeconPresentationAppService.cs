using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LeconPresentation;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class LeconPresentationAppService : ILeconPresentationAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ILeconPresentationRepository _leconPresentationRepository;

        public LeconPresentationAppService(IBus bus, IMapper mapper, ILeconPresentationRepository leconPresentationRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _leconPresentationRepository = leconPresentationRepository;
        }

       
        public void Add(LeconPresentationViewModel lecon)
        {
           _bus.SendCommand(new LeconPresentationAddCommand(
               lecon.Text, lecon.Category, lecon.SpeedReference, lecon.TimeReference, lecon.PrecisionReference, lecon.FontSize));
        }

        public IEnumerable<LeconPresentationViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<LeconPresentationViewModel>>(_leconPresentationRepository.GetAll());
        }

        public LeconPresentationViewModel GetById(Guid id)
        {
            return _mapper.Map<LeconPresentationViewModel>(_leconPresentationRepository.GetById(id));
        }

        public void Dispose()
        {
            _leconPresentationRepository.Dispose();
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new LeconPresentationDeleteCommand(id));
        }
    }
}
