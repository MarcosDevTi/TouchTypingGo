using AutoMapper;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Course.Commands.Student;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class StudentAppService : IStudentAppService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IBus _bus;

        public StudentAppService(IStudentRepository studentRepository, IBus bus)
        {
           
            _studentRepository = studentRepository;
            _bus = bus;
        }
        public void Add(StudentViewModel student)
        {
            _bus.SendCommand(new AddStudentCommand(student.Id, student.Name, student.Email));
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<StudentViewModel>>(_studentRepository.GetAll());
        }

        public StudentViewModel GetById(Guid id)
        {
            return Mapper.Map<StudentViewModel>(_studentRepository.GetById(id));
        }

        public void Updade(StudentViewModel student)
        {
            throw new NotImplementedException();
        }

        public void Delete(StudentViewModel student)
        {
            _bus.SendCommand(new DeleteStudentCommand(student.Id));
        }

        public void Dispose()
        {
            _studentRepository.Dispose();
        }

    }
}
