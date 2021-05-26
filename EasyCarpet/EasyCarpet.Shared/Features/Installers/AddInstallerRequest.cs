using MediatR;

namespace EasyCarpet.Shared.Features.Installers
{
    public record AddInstallerRequest(InstallerFormModel Installer) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/installer";
    }
}
