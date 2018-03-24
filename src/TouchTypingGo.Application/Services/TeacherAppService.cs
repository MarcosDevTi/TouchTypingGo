using AutoMapper;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course.Commands.Teacher;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class TeacherAppService : ITeacherAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ITeacherRepository _teacherRepository;

        public TeacherAppService(IBus bus, IMapper mapper, ITeacherRepository teacherRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _teacherRepository = teacherRepository;
        }

        public void Add(TeacherViewModel teacherViewModel)
        {
            var addCommand = new TeacherAddCommand(teacherViewModel.Id, teacherViewModel.Email, teacherViewModel.Name);
            _bus.SendCommand(addCommand);
        }

        public IEnumerable<TeacherViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TeacherViewModel>>(_teacherRepository.GetAll());
        }

        public IEnumerable<TeacherViewModel> GetCourseByTeacher(Guid teacherId)
        {
            throw new NotImplementedException();
        }

        public TeacherViewModel GetById(Guid id)
        {
            return _mapper.Map<TeacherViewModel>(_teacherRepository.GetById(id));
        }

        public void Update(TeacherViewModel teacherViewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new TeacherDeleteCommand(id));
        }

        public void Dispose()
        {
            _teacherRepository.Dispose();
        }
    }
}
