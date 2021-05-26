using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Customers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;
using EasyCarpet.Domain.Models;
using System;

namespace EasyCarpet.Api.Features.Customers
{
    public class AddCustomer : BaseAsyncEndpoint
        .WithRequest<AddCustomerRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public AddCustomer(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("api/customer")]
        [SwaggerOperation(
               Summary = "Add a new customer",
               Description = "Add a new customer",
               OperationId = "Customer.Add",
               Tags = new[] { "CustomerEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(AddCustomerRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Customer = new Customer()
                {
                    Id = request.Customer.Id,
                    FirstName = request.Customer.FirstName,
                    LastName = request.Customer.LastName,
                    Address = request.Customer.Address,
                    City = request.Customer.City,
                    State = request.Customer.State,
                    PhoneNumber = request.Customer.PhoneNumber,
                    CreatedDate = DateTime.Now
                };

                await _context.Customers.AddAsync(Customer);
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
