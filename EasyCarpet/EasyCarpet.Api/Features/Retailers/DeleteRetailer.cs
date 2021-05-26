using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Retailers
{
    public class DeleteRetailer : BaseAsyncEndpoint
        .WithRequest<Guid>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteRetailer(AppDbContext context)
        {
            _context = context;
        }

        [HttpDelete("api/retailer/{RetailerId:guid}")]
        [SwaggerOperation(
               Summary = "Delete a retailer",
               Description = "Delete a retailer",
               OperationId = "Retailer.Delete",
               Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(Guid RetailerId, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var retailer = await _context.Retailers.FindAsync(RetailerId);

                if (retailer != null)
                {
                    _context.Retailers.Remove(retailer);
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
