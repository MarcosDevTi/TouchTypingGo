using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Commands.Course;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class CourseAppService : ICourseAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;

        public CourseAppService(IBus bus, IMapper mapper, ICourseRepository courseRepository, ITeacherRepository teacherRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<CourseViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetAll());
        }

        public void Add(CourseViewModel courseViewModel)
        {
            //_bus.SendCommand(_mapper.Map<CourseAddCommand>(courseViewModel));
            _bus.SendCommand( 
                new CourseAddCommand(
                    courseViewModel.Code, courseViewModel.Name, courseViewModel.LimitDate, courseViewModel.TeacherId));
        }

        public void Update(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_mapper.Map<CourseUpdateCommand>(courseViewModel));
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new CourseDeleteCommand(id));
        }
        public SelectList Teachers()
        {
            return new SelectList(GetAllTeachers(), "Id", "Name");
        }

        public IEnumerable<TeacherViewModel> GetAllTeachers()
        {

            return _mapper.Map<IEnumerable<TeacherViewModel>>(_teacherRepository.GetAll());
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
