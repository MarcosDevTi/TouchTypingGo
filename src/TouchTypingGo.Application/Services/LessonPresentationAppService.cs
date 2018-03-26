using AutoMapper;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course.Commands.LessonPresentation;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class LessonPresentationAppService : ILessonPresentationAppService
    {
        private readonly IBus _bus;
        private readonly ILessonPresentationRepository _lessonPresentationRepository;
        private readonly IUser _user;

        public LessonPresentationAppService(IBus bus, ILessonPresentationRepository lessonPresentationRepository, IUser user)
        {
            _bus = bus;
            _lessonPresentationRepository = lessonPresentationRepository;
            _user = user;
        }


        public void Add(LessonPresentationViewModel lesson)
        {
            _bus.SendCommand(new LessonPresentationAddCommand(
               lesson.Name, lesson.Text, lesson.Category, lesson.SpeedReference,
               lesson.TimeReference, lesson.PrecisionReference, lesson.FontSize,
               _user.GetUderId()));
        }

        public IEnumerable<LessonPresentationViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<LessonPresentationViewModel>>(_lessonPresentationRepository.GetAll());
        }

        public IEnumerable<LessonPresentationViewModel> GetByUserAuthenticated()
        {
            return Mapper.Map<IEnumerable<LessonPresentationViewModel>>(_lessonPresentationRepository.Find(
                l => l.UserId == _user.GetUderId()));
        }

        public LessonPresentationViewModel GetById(Guid id)
        {
            return Mapper.Map<LessonPresentationViewModel>(_lessonPresentationRepository.GetById(id));
        }

        public void Dispose()
        {
            _lessonPresentationRepository.Dispose();
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new LessonPresentationDeleteCommand(id));
        }
    }
}
