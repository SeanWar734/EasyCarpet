using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Installers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;
using EasyCarpet.Domain.Models;
using System;

namespace EasyCarpet.Api.Features.Installers
{
    public class AddInstaller : BaseAsyncEndpoint
        .WithRequest<AddInstallerRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public AddInstaller(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("api/installer")]
        [SwaggerOperation(
               Summary = "Add an installer",
               Description = "Add an installer",
               OperationId = "Installer.Add",
               Tags = new[] { "InstallerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(AddInstallerRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var installer = new Installer()
                {
                    Id = request.Installer.Id,
                    FirstName = request.Installer.FirstName,
                    LastName = request.Installer.LastName,
                    Area = request.Installer.Area,
                    PhoneNumber = request.Installer.PhoneNumber,
                    SquareYardPrice = request.Installer.SquareYardPrice,
                    RetailerId = request.Installer.RetailerId,
                    CreatedDate = DateTime.Now
                };

                await _context.Installers.AddAsync(installer);
                await _context.SaveChangesAsync(cancellationToken);

                return Ok(new CommandResponse().Success());
            }
            else
            {
                return BadRequest(new CommandResponse().Errors(ModelState));
            }
        }
    }
}
