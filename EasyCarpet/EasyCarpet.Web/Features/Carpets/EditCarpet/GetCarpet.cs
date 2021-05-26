using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Carpets.EditCarpet
{
    public class GetCarpet : IRequestHandler<GetCarpetRequest, GetCarpetRequest.Response>
    {
        private readonly IHttpService _httpService;

        public GetCarpet(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetCarpetRequest.Response> Handle(GetCarpetRequest request, CancellationToken cancellationToken)
        {
            var url = $"{GetCarpetRequest.RouteTemplate}/{request.Id}";

            return await _httpService.SendGetAsync<GetCarpetRequest.Response>(url);
        }
    }
}

