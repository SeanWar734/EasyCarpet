using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Customers
{
    public record GetCustomerRequest(Guid CustomerId) : IRequest<GetCustomerRequest.Response>
    {
        public const string RouteTemplate = "/api/customer";
        public record Response(CustomerFormModel Customer);
    }
}
