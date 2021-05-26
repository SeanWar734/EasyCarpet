using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Installers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Installers.EditInstaller
{
    public class EditInstaller : IRequestHandler<EditInstallerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public EditInstaller(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(EditInstallerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPutAsync<EditInstallerRequest>(EditInstallerRequest.RouteTemplate, request);
        }
    }
}
