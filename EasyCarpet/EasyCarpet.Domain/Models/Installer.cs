using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Domain.Models
{
    public class Installer:BaseEntity
    {
        public Guid RetailerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal SquareYardPrice { get; set; }
        public decimal Area { get; set; }

        public Installer()
        {
            Id = Guid.NewGuid();
        }
    }
}
