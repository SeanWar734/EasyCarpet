using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Retailers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;
using EasyCarpet.Domain.Models;
using System;

namespace EasyCarpet.Api.Features.Retailers
{
    public class AddRetailer : BaseAsyncEndpoint
        .WithRequest<AddRetailerRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public AddRetailer(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("api/retailer")]
        [SwaggerOperation(
               Summary = "Add a retailer",
               Description = "Add a retailer",
               OperationId = "Retailer.Add",
               Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(AddRetailerRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Retailer = new Retailer()
                {
                    Id = request.Retailer.Id,
                    Address = request.Retailer.Address,
                    City = request.Retailer.City,
                    State = request.Retailer.State,
                    CompanyName = request.Retailer.CompanyName,
                    Description = request.Retailer.Description,
                    PhoneNumber = request.Retailer.PhoneNumber,
                    CreatedDate = DateTime.Now
                };

                await _context.Retailers.AddAsync(Retailer);
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
