using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course.Commands.Course;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class CourseAppService : ICourseAppService
    {
        private readonly IBus _bus;
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IHelperService _helperService;

        public CourseAppService(IBus bus, ICourseRepository courseRepository, ITeacherRepository teacherRepository, IHelperService helperService)
        {
            _bus = bus;
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;
            _helperService = helperService;
        }

        public IEnumerable<CourseViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetAll());
        }

        public string Add(CourseViewModel courseViewModel)
        {
            var code = _helperService.NewCode();
            _bus.SendCommand(new CourseAddCommand(courseViewModel.Name, courseViewModel.LimitDate, code));
            return code;
        }

        public void Update(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(Mapper.Map<CourseUpdateCommand>(courseViewModel));
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new CourseDeleteCommand(id));
        }

        public SelectList Teachers()
        {
            return new SelectList(Mapper.Map<IEnumerable<TeacherViewModel>>(_teacherRepository.GetAll()), "Id", "Name");
        }

        public IEnumerable<CourseViewModel> GetCourseByTeacher(Guid teacherId)
        {
            return Mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetByTeacher(teacherId));
        }

        public CourseViewModel GetById(Guid id)
        {
            return Mapper.Map<CourseViewModel>(_courseRepository.GetById(id));
        }

        public void Dispose()
        {
            _courseRepository.Dispose();
        }
    }
}
