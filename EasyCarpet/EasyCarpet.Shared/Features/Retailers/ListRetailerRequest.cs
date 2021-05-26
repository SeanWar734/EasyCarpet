using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Retailers
{
    public record ListRetailerRequest() : IRequest<ListRetailerRequest.Response>
    {
        public const string RouteTemplate = "/api/retailers";
        public record Response(List<ListRetailerDto> Retailers);
    }

    public record ListRetailerDto(Guid Id, string CompanyName, string Address, string City, string State, string PhoneNumber, string Description);
}