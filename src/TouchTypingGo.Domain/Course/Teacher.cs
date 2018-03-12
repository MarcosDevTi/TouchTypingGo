using System;
using FluentValidation;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Teacher : Entity<Teacher>
    {
        protected Teacher(){}

        public Teacher(string name, string email, Guid courseId)
        {
            Name = name;
            Email = email;
            CourseId = courseId;
        }

        public Teacher(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid CourseId { get; private set; }
        public virtual Course Course { get; set; }
        public override bool IsValid()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The Name is required!")
                .Length(2, 100).WithMessage("O Nome deve conter entre 2 e 100 caracteres");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("The Email is required!")
                .EmailAddress();

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
