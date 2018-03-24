using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Course : Entity<Course>
    {
        public Course(
            string code,
            string name,
            DateTime? limitDate,
            Guid teacherId)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
            LimitDate = limitDate;
            TeacherId = teacherId;
        }

        protected Course() { }
        public string Name { get; private set; }
        public string Code { get; private set; }
        public DateTime? LimitDate { get; private set; }
        public virtual ICollection<CourseLessonPresentation> CourseLessonPresentations { get; set; }
        [NotMapped]
        public virtual ICollection<Student> Students { get; private set; }
        public Guid TeacherId { get; private set; }
        public virtual Teacher Teacher { get; private set; }
        public bool Deleted { get; private set; }

        public void SetTeacher(Teacher teacher)
        {
            // if (!teacher.IsValid()) return;

            Teacher = teacher;

        }

        public void SetLessonPresentations(ICollection<CourseLessonPresentation> lessonPresentations)
        {
            CourseLessonPresentations = lessonPresentations;
        }

        public void DeleteCourse()
        {
            //TODO: Deve validar alguma regra?
            Deleted = true;
        }

        public override bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }

        #region Validations
        private void Validate()
        {
            ValidateName();
            ValidationResult = Validate(this);

            //Aditionals validations
            TeacherValidation();
        }

        private void ValidateName()
        {
            RuleFor(c => c.Name)
                 .NotEmpty().WithMessage("O nome não pode ser vazio")
                 .Length(2, 150).WithMessage("O nome precisa ter entre 2 e 150 caracteres");
        }

        private void TeacherValidation()
        {
            if (Teacher.IsValid()) return;

            foreach (var error in Teacher.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }
        #endregion

        public static class CourseFactory
        {
            public static Course NewCourseFactory(string name, DateTime? limitDate, string code)
            {
                return new Course
                {
                    Code = code,
                    Name = name,
                    LimitDate = limitDate
                };
            }
        }




        //cod  = RandomString(4);
    }
}
