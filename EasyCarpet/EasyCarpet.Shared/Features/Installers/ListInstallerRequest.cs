using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Installers
{
    public record ListInstallerRequest() : IRequest<ListInstallerRequest.Response>
    {
        public const string RouteTemplate = "/api/installers";
        public record Response(List<ListInstallerDto> Installers);
    }

    public record ListInstallerDto(Guid Id, string RetailerName, Guid RetailerId, string FirstName, string LastName, string PhoneNumber, decimal SquareYardPrice, decimal Area);
}