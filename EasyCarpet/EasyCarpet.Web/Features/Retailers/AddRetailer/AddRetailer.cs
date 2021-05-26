using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Retailers.AddRetailer
{
    public class AddRetailer : IRequestHandler<AddRetailerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public AddRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(AddRetailerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPostAsync<AddRetailerRequest>(AddRetailerRequest.RouteTemplate, request);
        }
    }
}
