using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Orders
{
    public record GetOrderRequest(Guid Id) : IRequest<GetOrderRequest.Response>
    {
        public const string RouteTemplate = "/api/order";
        public record Response(OrderFormModel Order);
    }
}
