using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Extensions;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Lookups
{
    public class LookupRetailer : IRequestHandler<LookupRetailerRequest, LookupRetailerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public LookupRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<LookupRetailerRequest.Response> Handle(LookupRetailerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{LookupRetailerRequest.RouteTemplate}?{request.ToUrl()}";
            return await _httpService.SendGetAsync<LookupRetailerRequest.Response>(url);
        }
    }
}
