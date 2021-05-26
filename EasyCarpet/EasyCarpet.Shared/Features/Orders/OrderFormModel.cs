using EasyCarpet.Shared.Features.Retailers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Orders
{
    public class OrderFormModel
    {
        public Guid Id { get; set; }
        public LookupRetailerDto Retailer { get; set; }
        public Guid CustomerId { get; set; }
        public Guid InstallerId { get; set; }
        public Guid CarpetId { get; set; }
        public decimal Total { get; set; }
    }
}
