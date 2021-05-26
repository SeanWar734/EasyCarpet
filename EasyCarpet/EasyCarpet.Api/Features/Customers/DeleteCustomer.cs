using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Customers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Customers
{
    public class DeleteCustomer : BaseAsyncEndpoint
        .WithRequest<Guid>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteCustomer(AppDbContext context)
        {
            _context = context;
        }

        [HttpDelete("api/customer/{CustomerId:guid}")]
        [SwaggerOperation(
               Summary = "Delete a customer",
               Description = "Delete a customer",
               OperationId = "Customer.Delete",
               Tags = new[] { "CustomerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(Guid CustomerId, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var customer = await _context.Customers.FindAsync(CustomerId);

                if (customer != null)
                {
                    _context.Customers.Remove(customer);
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
