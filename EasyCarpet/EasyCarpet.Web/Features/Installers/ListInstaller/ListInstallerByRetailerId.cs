using EasyCarpet.Shared.Features.Installers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Installers.ListInstaller
{
    public class ListInstallerByRetailerId : IRequestHandler<ListInstallerByRetailerIdRequest, ListInstallerByRetailerIdRequest.Response>
    {
        private readonly IHttpService _httpService;

        public ListInstallerByRetailerId(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ListInstallerByRetailerIdRequest.Response> Handle(ListInstallerByRetailerIdRequest request, CancellationToken cancellationToken)
        {
            var url = $"{ListInstallerByRetailerIdRequest.RouteTemplate}/retailer/{request.RetailerId}";
            return await _httpService.SendGetAsync<ListInstallerByRetailerIdRequest.Response>(url);
        }
    }
}

