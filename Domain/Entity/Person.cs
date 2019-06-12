using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Domain.Entity.Base;

namespace Domain.Entity
{
    public class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool CanBeDriver { get; set; }
        public DateTime Birthday { get; set; } 
        public virtual ICollection<SocialAccount> SocialAccounts { get; set; }
        public virtual ICollection<PersonOrder> PersonOrders { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            string pattern = @"^\w{1, 10}([\-\`\'\s])?\w{2, 15}$";
            string antiPattern = @"\d";

            if (!Regex.IsMatch(this.FirstName, pattern) || Regex.IsMatch(this.FirstName, antiPattern))
                yield return new ValidationResult(nameof(FirstName));

            if (!Regex.IsMatch(this.SecondName, pattern) || Regex.IsMatch(this.SecondName, antiPattern))
                yield return new ValidationResult(nameof(SecondName));
        }
    }
}