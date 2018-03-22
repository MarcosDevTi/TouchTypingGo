using System;
using FluentValidation;
using FluentValidation.Results;
using TouchTypingGo.Domain.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace TouchTypingGo.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
            DateCreated = DateTime.Now;
        }
        public Guid Id { get; protected set; }

        public DateTime DateCreated { get; protected set; }
        public Guid? UserId { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            return !ReferenceEquals(null, compareTo) && Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity<T> a, Entity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity<T> a, Entity<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }

        public abstract bool IsValid();
        public ValidationResult ValidationResult { get; protected set; }
    }
}
