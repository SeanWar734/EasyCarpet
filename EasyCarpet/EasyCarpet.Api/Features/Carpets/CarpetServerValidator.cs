using EasyCarpet.Domain;
using EasyCarpet.Shared.Features.Carpets;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EasyCarpet.Shared.Features.Carpets.CarpetFormModel;

namespace EasyCarpet.Api.Features.Carpets
{
    public class CarpetServerValidator:AbstractValidator<CarpetFormModel>
    {
        private readonly AppDbContext _context;

        public CarpetServerValidator(AppDbContext context)
        {
            _context = context;

            Include(new CarpetValidator());

            //RuleFor(x => x).Must(x => NoDuplicateNames(x)).WithMessage("No duplicate names");
        }

        public bool NoDuplicateNames(CarpetFormModel carpet)
        {
            return !_context.Carpets.Any(x => x.Name == carpet.Name);
        }
    }
}
