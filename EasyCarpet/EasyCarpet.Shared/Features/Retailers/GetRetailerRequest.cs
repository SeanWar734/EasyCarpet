using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Retailers
{
    public record GetRetailerRequest(Guid Id) : IRequest<GetRetailerRequest.Response>
    {
        public const string RouteTemplate = "/api/retailer";
        public record Response(RetailerFormModel Retailer);
    }
}
