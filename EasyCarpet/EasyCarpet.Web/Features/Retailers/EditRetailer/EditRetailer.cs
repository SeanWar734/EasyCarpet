using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Retailers.EditRetailer
{
    public class EditRetailer : IRequestHandler<EditRetailerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public EditRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(EditRetailerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPutAsync<EditRetailerRequest>(EditRetailerRequest.RouteTemplate, request);
        }
    }
}
