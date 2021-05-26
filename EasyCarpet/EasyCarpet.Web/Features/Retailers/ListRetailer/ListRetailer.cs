using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Retailers.ListRetailer
{
    public class ListRetailer : IRequestHandler<ListRetailerRequest, ListRetailerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public ListRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ListRetailerRequest.Response> Handle(ListRetailerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendGetAsync<ListRetailerRequest.Response>(ListRetailerRequest.RouteTemplate);
        }
    }
}

