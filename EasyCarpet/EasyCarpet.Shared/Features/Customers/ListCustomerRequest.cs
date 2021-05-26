using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Customers
{
    public record ListCustomerRequest() : IRequest<ListCustomerRequest.Response>
    {
        public const string RouteTemplate = "/api/customers";
        public record Response(List<ListCustomerDto> Customers);
    }

    public record ListCustomerDto(Guid Id, string FirstName, string LastName, string Address, string City, string State, string PhoneNumber);
}
