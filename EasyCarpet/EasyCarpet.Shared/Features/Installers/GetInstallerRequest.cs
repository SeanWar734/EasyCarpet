using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Installers
{
    public record GetInstallerRequest(Guid InstallerId) : IRequest<GetInstallerRequest.Response>
    {
        public const string RouteTemplate = "/api/installer";
        public record Response(InstallerFormModel Installer);
    }
}
