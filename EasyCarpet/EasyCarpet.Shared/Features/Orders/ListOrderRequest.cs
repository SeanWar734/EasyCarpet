using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Orders
{
    public record ListOrderRequest() : IRequest<ListOrderRequest.Response>
    {
        public const string RouteTemplate = "/api/orders";
        public record Response(List<ListOrderDto> Orders);
    }

    public record ListOrderDto(Guid Id, string CustomerFirstName, string CustomerLastName, string RetailerName, string InstallerFirstName
        , string InstallerLastName, string CarpetName, decimal Total);
}