using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Domain.Models
{
    public class Order:BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Guid RetailerId { get; set; }
        public Guid InstallerId { get; set; }
        public Guid CarpetId { get; set; }
        public decimal Total { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}
