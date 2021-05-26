using MediatR;

namespace EasyCarpet.Shared.Features.Orders
{
    public record AddOrderRequest(OrderFormModel Order) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/order";
    }
}
