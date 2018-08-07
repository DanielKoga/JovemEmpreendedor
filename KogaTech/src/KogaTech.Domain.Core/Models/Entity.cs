using FluentValidation;
using FluentValidation.Results;

namespace KogaTech.Domain.Core.Models
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        public ValidationResult ValidationResult { get; protected set; }

        protected Entity()
        {
            ValidationResult = new ValidationResult();
        }

        protected virtual bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }

        protected abstract void Validate();
    }
}
