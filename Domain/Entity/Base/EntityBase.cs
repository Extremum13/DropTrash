using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Base
{
    public abstract class EntityBase : IValidatableObject
    {
        public int Id { get; set; }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            => new ValidationResult[0];
    }
}