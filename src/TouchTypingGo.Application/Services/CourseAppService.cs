using System;
using System.Collections.Generic;
using System.Linq;
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
            //return _mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetAll());
        }

        

        //public void Add(CourseViewModel courseViewModel)
        //{
            
        //    //_bus.SendCommand( 
        //    //    new CourseAddCommand(courseViewModel.Name, courseViewModel.LimitDate));
        //}

        //

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
            //var testea = _mapper.Map<CourseViewModel>(_courseRepository.GetCoursesWithLessons());
            var cursos = new HashSet<CourseViewModel>();
            var lista = _courseRepository.GetCoursesWithLessons();
            var listaLp = new HashSet<LessonPresentationViewModel>();
            foreach (var lpw in lista)
            {
                foreach (var lp in lpw.CourseLessonPresentations)
                {
                    listaLp.Add(_mapper.Map<LessonPresentationViewModel>(lp.LessonPresentation));
                }

                var courseVwModel = _mapper.Map<CourseViewModel>(lpw);
                courseVwModel.Lessons = listaLp;
                
                cursos.Add(courseVwModel);
                listaLp = new HashSet<LessonPresentationViewModel>();
            }

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
            var listaLp = new HashSet<LessonPresentationViewModel>();
            var courseRepository = _courseRepository.GetById(id);
            foreach (var lecon in courseRepository.CourseLessonPresentations)
            {
                listaLp.Add(_mapper.Map<LessonPresentationViewModel>(lecon.LessonPresentation));
            }
            var course = _mapper.Map<CourseViewModel>(_courseRepository.GetById(id));
            course.Lessons = listaLp;

            return course;
        }

       
        public void Dispose()
        {
            _courseRepository.Dispose();
        }

       
    }
}
