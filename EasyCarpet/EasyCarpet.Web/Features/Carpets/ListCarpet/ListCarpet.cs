using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Carpets.ListCarpet
{
    public class ListCarpet : IRequestHandler<ListCarpetRequest, ListCarpetRequest.Response>
    {
        private readonly IHttpService _httpService;

        public ListCarpet(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ListCarpetRequest.Response> Handle(ListCarpetRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendGetAsync<ListCarpetRequest.Response>(ListCarpetRequest.RouteTemplate);
        }
    }
}

