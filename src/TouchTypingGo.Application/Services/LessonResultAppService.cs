using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LessonResult;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class LessonResultAppService : ILessonResultAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ILessonResultRepository _lessonResultRepository;
        private readonly ILessonPresentationRepository _lessonPresentationRepository;
        private readonly IUser _user;

        public LessonResultAppService(
            IBus bus,
            IMapper mapper,
            ILessonResultRepository lessonResultRepository,
            ILessonPresentationRepository lessonPresentationRepository, IUser user)
        {
            _bus = bus;
            _mapper = mapper;
            _lessonResultRepository = lessonResultRepository;
            _lessonPresentationRepository = lessonPresentationRepository;
            _user = user;
        }
        public void Add(LessonResultViewModel lessonResultViewModel)
        {

            _bus.SendCommand(new AddLessonResultCommand(
                lessonResultViewModel.Try,
                lessonResultViewModel.Wpm,
                lessonResultViewModel.Time,
                lessonResultViewModel.Errors,
                lessonResultViewModel.EhAuthenticated,
                lessonResultViewModel.ErrorKey,
                lessonResultViewModel.Active,
                lessonResultViewModel.LessonPresentationId,
                _user.GetUderId()));
        }

        public IEnumerable<LessonResultViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<LessonResultViewModel>>(_lessonResultRepository.GetAll());
        }

        public IEnumerable<LessonResultViewModel> GetByUserAuthenticated()
        {
            return _mapper.Map<IEnumerable<LessonResultViewModel>>(_lessonResultRepository.GetAll());
        }

        public LessonResultViewModel GetById(Guid id)
        {
            return _mapper.Map<LessonResultViewModel>(_lessonResultRepository.GetById(id));
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new DeleteLessonResultCommand(id));
        }

        public SelectList LessonsPresentationsSelect()
        {
            return new SelectList(GetAlllessonsPresentations(), "Id", "Name");
        }

        public IEnumerable<LessonPresentation> GetAlllessonsPresentations()
        {
            return _lessonPresentationRepository.GetAll();
        }

        public void Dispose()
        {
            _lessonResultRepository.Dispose();
        }
    }
}
