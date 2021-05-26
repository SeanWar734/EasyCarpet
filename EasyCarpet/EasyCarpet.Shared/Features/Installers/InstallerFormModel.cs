using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Installers
{
    public class InstallerFormModel
    {
        public Guid Id { get; set; }
        public Guid RetailerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal SquareYardPrice { get; set; }
        public decimal Area { get; set; }

        public class Installervalidator : AbstractValidator<InstallerFormModel>
        {
            public Installervalidator()
            {
                RuleFor(x => x.RetailerId).NotEmpty().WithMessage("Must pick a retailer");
            }
        }
    }
}
