using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Orders
{
    public record DeleteOrderRequest(Guid OrderId) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/order";
    }
}
