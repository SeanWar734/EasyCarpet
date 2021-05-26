using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Carpets
{
    public class CarpetFormModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal SquareYardPrice { get; set; }
        public string Brand { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public class CarpetValidator : AbstractValidator<CarpetFormModel>
        {
            public CarpetValidator()
            {
                RuleFor(x => x.Width)
                    .LessThan(16.0m).WithMessage("Carpet is less than 16 feet wide")
                    .GreaterThan(9.0m).WithMessage("Carpet is more than 9 feet wide");

                RuleFor(x => x.SquareYardPrice)
                    .GreaterThan(1.0m).WithMessage("Carpet must be more than $1 per yard")
                    .LessThan(100.0m).WithMessage("Carpet cannot excede $100 per yard");
            }
        }
    }
}
