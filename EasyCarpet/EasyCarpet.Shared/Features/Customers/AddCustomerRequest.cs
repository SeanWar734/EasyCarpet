using MediatR;

namespace EasyCarpet.Shared.Features.Customers
{
    public record AddCustomerRequest(CustomerFormModel Customer) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/customer";
    }
}
