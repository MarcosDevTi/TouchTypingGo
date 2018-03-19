using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LeconResult;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class LeconResultAppService : ILeconResultAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ILeconResultRepository _leconResultRepository;
        private readonly ILeconPresentationRepository _leconPresentationRepository;

        public LeconResultAppService(IBus bus, IMapper mapper, ILeconResultRepository leconResultRepository, ILeconPresentationRepository leconPresentationRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _leconResultRepository = leconResultRepository;
            _leconPresentationRepository = leconPresentationRepository;
        }
        public void Add(LeconResultViewModel leconResultViewModel)
        {
           
            _bus.SendCommand(new AddLeconResultCommand(
                leconResultViewModel.Try,
                leconResultViewModel.Wpm,
                leconResultViewModel.Time,
                leconResultViewModel.Errors,
                leconResultViewModel.EhAuthenticated,
                leconResultViewModel.ErrorKey,
                leconResultViewModel.Active,
                leconResultViewModel.LeconPresentationId));
        }

        public IEnumerable<LeconResultViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<LeconResultViewModel>>(_leconResultRepository.GetAll());
        }

        public LeconResultViewModel GetById(Guid id)
        {
            return _mapper.Map<LeconResultViewModel>(_leconResultRepository.GetById(id));
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new DeleteLeconResultCommand(id));
        }

        public SelectList LeconsPresentationsSelect()
        {
            return new SelectList(GetAllLeconsPresentations(), "Id", "Text");
        }

        public IEnumerable<LeconPresentation> GetAllLeconsPresentations()
        {
            return _leconPresentationRepository.GetAll();
        }

        public void Dispose()
        {
            _leconResultRepository.Dispose();
        }
    }
}
