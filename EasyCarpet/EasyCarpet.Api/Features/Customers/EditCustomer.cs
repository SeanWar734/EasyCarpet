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
    public class EditCustomer : BaseAsyncEndpoint
        .WithRequest<EditCustomerRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public EditCustomer(AppDbContext context)
        {
            _context = context;
        }

        [HttpPut("api/customer")]
        [SwaggerOperation(
               Summary = "Edit a customer",
               Description = "Edit a customer",
               OperationId = "Customer.Edit",
               Tags = new[] { "CustomerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(EditCustomerRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var customer = await _context.Customers.FindAsync(request.Customer.Id);

                if (customer != null)
                {
                    customer.FirstName = request.Customer.FirstName;
                    customer.LastName = request.Customer.LastName;
                    customer.Address = request.Customer.Address;
                    customer.City = request.Customer.City;
                    customer.State = request.Customer.State;
                    customer.PhoneNumber = request.Customer.PhoneNumber;
                    customer.ModifiedDate = DateTime.Now;

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
