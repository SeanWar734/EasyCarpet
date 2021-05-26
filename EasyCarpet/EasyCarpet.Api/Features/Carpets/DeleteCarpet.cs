using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Carpets;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Carpets
{
    public class DeleteCarpet : BaseAsyncEndpoint
        .WithRequest<Guid>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteCarpet(AppDbContext context)
        {
            _context = context;
        }

        [HttpDelete("api/carpet/{CarpetId:guid}")]
        [SwaggerOperation(
               Summary = "Delete a carpet",
               Description = "Delete a carpet",
               OperationId = "Carpet.Delete",
               Tags = new[] { "CarpetEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(Guid CarpetId, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Carpet = await _context.Carpets.FindAsync(CarpetId);

                if (Carpet != null)
                {
                    _context.Remove(Carpet);
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
