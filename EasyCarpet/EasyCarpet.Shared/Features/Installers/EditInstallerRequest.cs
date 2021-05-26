using MediatR;

namespace EasyCarpet.Shared.Features.Installers
{
    public record EditInstallerRequest(InstallerFormModel Installer) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/installer";
    }
}
