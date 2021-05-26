using EasyCarpet.Shared.Features.Installers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Installers.EditInstaller
{
    public class GetInstaller : IRequestHandler<GetInstallerRequest, GetInstallerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public GetInstaller(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetInstallerRequest.Response> Handle(GetInstallerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{GetInstallerRequest.RouteTemplate}/{request.InstallerId}";

            return await _httpService.SendGetAsync<GetInstallerRequest.Response>(url);
        }
    }
}

