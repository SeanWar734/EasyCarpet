using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Orders;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using EasyCarpet.Domain.Models;
using System.Threading.Tasks;
using System;

namespace EasyCarpet.Api.Features.Orders
{
    public class AddOrder : BaseAsyncEndpoint
        .WithRequest<AddOrderRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public AddOrder(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("api/order")]
        [SwaggerOperation(
               Summary = "Add an order",
               Description = "Add an order",
               OperationId = "Order.Add",
               Tags = new[] { "OrderEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(AddOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var order = new Order()
                {
                    Id = request.Order.Id,
                    InstallerId = request.Order.InstallerId,
                    CarpetId = request.Order.CarpetId,
                    CustomerId = request.Order.CustomerId,
                    RetailerId = request.Order.Retailer.Id,
                    Total = request.Order.Total,
                    CreatedDate = DateTime.Now
                };

                await _context.Orders.AddAsync(order);
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
