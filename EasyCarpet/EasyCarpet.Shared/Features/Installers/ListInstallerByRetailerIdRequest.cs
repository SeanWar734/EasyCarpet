using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Installers
{
    public record ListInstallerByRetailerIdRequest(Guid RetailerId) : IRequest<ListInstallerByRetailerIdRequest.Response>
    {
        public const string RouteTemplate = "/api/installers";
        public record Response(List<ListInstallerDto> Installers);
    }
}
