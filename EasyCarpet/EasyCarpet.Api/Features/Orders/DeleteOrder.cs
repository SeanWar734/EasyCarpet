using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Orders
{
    public class DeleteOrder : BaseAsyncEndpoint
        .WithRequest<Guid>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteOrder(AppDbContext context)
        {
            _context = context;
        }

        [HttpDelete("api/order/{OrderId:guid}")]
        [SwaggerOperation(
               Summary = "Delete an order",
               Description = "Delete an order",
               OperationId = "Order.Delete",
               Tags = new[] { "OrderEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(Guid OrderId, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var order = await _context.Orders.FindAsync(OrderId);

                if (order != null)
                {
                    _context.Orders.Remove(order);
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
