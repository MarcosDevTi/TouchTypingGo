using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class CourseAppService : ICourseAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;

        public CourseAppService(IBus bus, IMapper mapper, ICourseRepository courseRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public void Add(CourseViewModel courseViewModel)
        {
            var addCommand = _mapper.Map<CourseAddCommand>(courseViewModel);
            _bus.SendCommand(addCommand);
        }

        public void Update(CourseViewModel courseViewModel)
        {
            var updateCourseCommand = _mapper.Map<CourseUpdateCommand>(courseViewModel);
            _bus.SendCommand(updateCourseCommand);
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new CourseDeleteCommand(id));
        }

        public IEnumerable<CourseViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetAll());
        }

        public IEnumerable<CourseViewModel> GetCourseByTeacher(Guid teacherId)
        {
            return _mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetByTeacher(teacherId));
        }

        public CourseViewModel GetById(Guid id)
        {
            return _mapper.Map<CourseViewModel>(_courseRepository.GetById(id));
        }

       
        public void Dispose()
        {
            _courseRepository.Dispose();
        }

    }
}
