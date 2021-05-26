using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Retailers.EditRetailer
{
    public class GetRetailer : IRequestHandler<GetRetailerRequest, GetRetailerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public GetRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetRetailerRequest.Response> Handle(GetRetailerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{GetRetailerRequest.RouteTemplate}/{request.Id}";

            return await _httpService.SendGetAsync<GetRetailerRequest.Response>(url);
        }
    }
}
