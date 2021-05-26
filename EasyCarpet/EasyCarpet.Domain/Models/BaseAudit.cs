using System;

namespace EasyCarpet.Domain.Models
{
    public abstract class BaseAudit
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
