using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Retailers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Retailers.EditRetailer
{
    public class DeleteRetailer : IRequestHandler<DeleteRetailerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public DeleteRetailer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(DeleteRetailerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{DeleteRetailerRequest.RouteTemplate}/{request.RetailerId}";
            return await _httpService.SendDeleteWithResponseAsync(url);
        }
    }
}
