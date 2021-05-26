using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Retailers
{
    public class LookupRetailerDto
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }

        public LookupRetailerDto(Guid Id, string CompanyName)
        {
            this.Id = Id;
            this.CompanyName = CompanyName;
        }
    }
}
