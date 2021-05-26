using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Retailers
{
    public record DeleteRetailerRequest(Guid RetailerId) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/retailer";
    }
}
