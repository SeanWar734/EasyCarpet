using MediatR;

namespace EasyCarpet.Shared.Features.Customers
{
    public record EditCustomerRequest(CustomerFormModel Customer) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/customer";
    }
}
