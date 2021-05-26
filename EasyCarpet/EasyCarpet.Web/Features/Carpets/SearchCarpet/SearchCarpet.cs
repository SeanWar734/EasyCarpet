using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Web.Extensions;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Carpets.SearchCarpet
{
    public class SearchCarpet : IRequestHandler<SearchCarpetRequest, SearchCarpetRequest.Response>
    {
        private readonly IHttpService _httpService;

        public SearchCarpet(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<SearchCarpetRequest.Response> Handle(SearchCarpetRequest request, CancellationToken cancellationToken)
        {
            var url = $"{SearchCarpetRequest.RouteTemplate}?{request.ToUrl()}";
            return await _httpService.SendGetAsync<SearchCarpetRequest.Response>(url);
        }
    }
}

