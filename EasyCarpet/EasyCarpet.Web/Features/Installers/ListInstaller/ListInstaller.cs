using EasyCarpet.Shared.Features.Installers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Installers.ListInstaller
{
    public class ListInstaller : IRequestHandler<ListInstallerRequest, ListInstallerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public ListInstaller(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ListInstallerRequest.Response> Handle(ListInstallerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendGetAsync<ListInstallerRequest.Response>(ListInstallerRequest.RouteTemplate);
        }
    }
}

