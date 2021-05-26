using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Customers
{
    public record DeleteCustomerRequest(Guid CustomerId) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/customer";
    }
}
