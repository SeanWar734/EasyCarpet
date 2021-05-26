using MediatR;

namespace EasyCarpet.Shared.Features.Orders
{
    public record EditOrderRequest(OrderFormModel Order) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/order";
    }
}
