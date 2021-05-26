using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Installers
{
    public record DeleteInstallerRequest(Guid InstallerId) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/installer";
    }
}
