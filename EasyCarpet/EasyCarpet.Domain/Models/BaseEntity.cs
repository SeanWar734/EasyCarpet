using System;

namespace EasyCarpet.Domain.Models
{
    public abstract class BaseEntity : BaseAudit
    {
        public Guid Id { get; set; }
    }
}
