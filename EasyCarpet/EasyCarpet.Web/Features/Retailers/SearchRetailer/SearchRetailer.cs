using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Extensions;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Retailers.SearchRetailer
{
    public class SearchRetailer : IRequestHandler<SearchRetailerRequest, SearchRetailerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public SearchRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<SearchRetailerRequest.Response> Handle(SearchRetailerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{SearchRetailerRequest.RouteTemplate}?{request.ToUrl()}";
            return await _httpService.SendGetAsync<SearchRetailerRequest.Response>(url);
        }
    }
}

