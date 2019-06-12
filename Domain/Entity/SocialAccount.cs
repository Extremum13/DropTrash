using Domain.Entity.Base;
using Domain.Enum;

namespace Domain.Entity
{
    public class SocialAccount : EntityBase
    {
        public string SocialId { get; set; }
        public SocialMedia SocialMedia { get; set; }
        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}

