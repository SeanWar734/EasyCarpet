using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Retailers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Retailers
{
    public class EditRetailer : BaseAsyncEndpoint
        .WithRequest<EditRetailerRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public EditRetailer(AppDbContext context)
        {
            _context = context;
        }

        [HttpPut("api/retailer")]
        [SwaggerOperation(
               Summary = "Edit a retailer",
               Description = "Edit a retailer",
               OperationId = "Retailer.Edit",
               Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(EditRetailerRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Retailer = await _context.Retailers.FindAsync(request.Retailer.Id);

                if (Retailer != null)
                {
                    Retailer.Id = request.Retailer.Id;
                    Retailer.Address = request.Retailer.Address;
                    Retailer.City = request.Retailer.City;
                    Retailer.State = request.Retailer.State;
                    Retailer.CompanyName = request.Retailer.CompanyName;
                    Retailer.Description = request.Retailer.Description;
                    Retailer.PhoneNumber = request.Retailer.PhoneNumber;
                    Retailer.ModifiedDate = DateTime.Now;

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
