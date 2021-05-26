using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Installers
{
    public class DeleteInstaller : BaseAsyncEndpoint
        .WithRequest<Guid>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteInstaller(AppDbContext context)
        {
            _context = context;
        }

        [HttpDelete("api/installer/{InstallerId:guid}")]
        [SwaggerOperation(
               Summary = "Delete an installer",
               Description = "Delete an installer",
               OperationId = "Installer.Delete",
               Tags = new[] { "InstallerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(Guid InstallerId, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Installer = await _context.Installers.FindAsync(InstallerId);

                if (Installer != null)
                {
                    _context.Installers.Remove(Installer);
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
