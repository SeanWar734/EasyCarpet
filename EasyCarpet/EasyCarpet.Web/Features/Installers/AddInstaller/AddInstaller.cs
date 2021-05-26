using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Installers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Installers.AddInstaller
{
    public class AddInstaller : IRequestHandler<AddInstallerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public AddInstaller(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(AddInstallerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPostAsync<AddInstallerRequest>(AddInstallerRequest.RouteTemplate, request);
        }
    }
}
