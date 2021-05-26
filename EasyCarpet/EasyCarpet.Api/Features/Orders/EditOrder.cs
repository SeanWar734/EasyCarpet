using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Orders;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Orders
{
    public class EditOrder : BaseAsyncEndpoint
        .WithRequest<EditOrderRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public EditOrder(AppDbContext context)
        {
            _context = context;
        }

        [HttpPut("api/order")]
        [SwaggerOperation(
               Summary = "Edit an order",
               Description = "Edit an order",
               OperationId = "Order.Edit",
               Tags = new[] { "OrderEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(EditOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var order = await _context.Orders.FindAsync(request.Order.Id);

                if (order != null)
                {
                    order.Id = request.Order.Id;
                    order.InstallerId = request.Order.InstallerId;
                    order.CarpetId = request.Order.CarpetId;
                    order.CustomerId = request.Order.CustomerId;
                    order.RetailerId = request.Order.Retailer.Id;
                    order.Total = request.Order.Total;
                    order.ModifiedDate = DateTime.Now;

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
