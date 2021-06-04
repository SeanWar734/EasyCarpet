using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace EasyCarpet.Domain.Models
{
    [Table("Carpet")]
    public class Carpet : BaseEntity
    {
        public string Name { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal SquareYardPrice { get; set; }
        public string Brand { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
        public string ImageFileName { get; set; }

        public Carpet()
        {
            Id = Guid.NewGuid();
        }
    }
}
