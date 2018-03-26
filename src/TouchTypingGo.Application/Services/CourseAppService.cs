using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course;
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
        private readonly IHelperService _helperService;

        public CourseAppService(IBus bus, IMapper mapper, ICourseRepository courseRepository, ITeacherRepository teacherRepository, IHelperService helperService)
        {
            _bus = bus;
            _mapper = mapper;
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;
            _helperService = helperService;
        }

        public IEnumerable<CourseViewModel> GetAll()
        {
            return GetCoursesWithLessons();
        }

        public string Add(CourseViewModel courseViewModel)
        {
            var code = _helperService.NewCode();
            _bus.SendCommand(
                new CourseAddCommand(courseViewModel.Name, courseViewModel.LimitDate, code));
            return code;
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

        public IEnumerable<CourseViewModel> GetCoursesWithLessons()
        {
            var cursos = new HashSet<CourseViewModel>();

            _courseRepository.GetCoursesWithLessons().ToList()
                .ForEach(c => cursos.Add(CourseViewModelMap(c)));

            return cursos;
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
            return CourseViewModelMap(_courseRepository.GetById(id));
        }

        private CourseViewModel CourseViewModelMap(Course course)
        {
            return new CourseViewModel
            {
                Id = course.Id,
                Name = course.Name,
                Code = course.Code,
                LimitDate = course.LimitDate,
                TeacherId = course.TeacherId,
                Lessons = course.CourseLessonPresentations.Select(
                    x => _mapper.Map<LessonPresentationViewModel>(x.LessonPresentation)).ToList()
            };
        }

        public void Dispose()
        {
            _courseRepository.Dispose();
        }
    }
}
