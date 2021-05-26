using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Installers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Installers
{
    public class EditInstaller : BaseAsyncEndpoint
        .WithRequest<EditInstallerRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public EditInstaller(AppDbContext context)
        {
            _context = context;
        }

        [HttpPut("api/installer")]
        [SwaggerOperation(
               Summary = "Edit an installer",
               Description = "Edit an installer",
               OperationId = "Installer.Edit",
               Tags = new[] { "InstallerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(EditInstallerRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var installer = await _context.Installers.FindAsync(request.Installer.Id);

                if (installer != null)
                {
                    installer.Id = request.Installer.Id;
                    installer.FirstName = request.Installer.FirstName;
                    installer.LastName = request.Installer.LastName;
                    installer.Area = request.Installer.Area;
                    installer.PhoneNumber = request.Installer.PhoneNumber;
                    installer.SquareYardPrice = request.Installer.SquareYardPrice;
                    installer.RetailerId = request.Installer.RetailerId;
                    installer.ModifiedDate = DateTime.Now;

                    await _context.SaveChangesAsync(cancellationToken);
                }

                return Ok(new CommandResponse().Success());
            }
            else
            {
                return BadRequest(new CommandResponse().Errors(ModelState));
            }
        }
    }
}
