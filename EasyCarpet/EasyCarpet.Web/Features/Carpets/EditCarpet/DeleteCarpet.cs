using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Carpets.EditCarpet
{
    public class DeleteCarpet : IRequestHandler<DeleteCarpetRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public DeleteCarpet(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(DeleteCarpetRequest request, CancellationToken cancellationToken)
        {
            var url = $"{DeleteCarpetRequest.RouteTemplate}/{request.CarpetId}";
            return await _httpService.SendDeleteWithResponseAsync(url);
        }
    }
}
