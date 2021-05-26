using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Installers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Installers.EditInstaller
{
    public class DeleteInstaller : IRequestHandler<DeleteInstallerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public DeleteInstaller(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(DeleteInstallerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{DeleteInstallerRequest.RouteTemplate}/{request.InstallerId}";
            return await _httpService.SendDeleteWithResponseAsync(url);
        }
    }
}
