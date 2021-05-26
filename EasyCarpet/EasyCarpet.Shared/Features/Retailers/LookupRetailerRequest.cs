using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Retailers
{
    public record LookupRetailerRequest(int Count, string CompanyName) : IRequest<LookupRetailerRequest.Response>
    {
        public const string RouteTemplate = "/api/retailer/lookup";
        public record Response(List<LookupRetailerDto> Retailers);
    }
}
