using System;
using System.Collections.Generic;
using FluentValidation;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Course : Entity<Course>
    {
        public Course(
            string code,
            string name,
            DateTime dateLimit)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
            //DateCreated = new DateTime();

            if (Name.Length < 3)
            {

            }
        }
        public string Code { get; private set; }
        public string Name { get; private set; }

        public DateTime LimitDate { get; private set; }
        public ICollection<LeconPresentation> Lecons { get; private set; }
        public ICollection<Student> Students { get; private set; }
        public Teacher Teacher { get;private set; }

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
        }

        private void ValidateName()
        {
            RuleFor(c => c.Name)
                 .NotEmpty().WithMessage("O nome não pode ser vazio")
                 .Length(2, 150).WithMessage("Onome precisa ter entre 2 e 150 caracteres");
        }
        #endregion
    }
}
