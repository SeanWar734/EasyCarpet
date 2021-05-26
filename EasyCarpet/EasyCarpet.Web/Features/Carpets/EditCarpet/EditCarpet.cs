using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Carpets.EditCarpet
{
    public class EditCarpet : IRequestHandler<EditCarpetRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public EditCarpet(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(EditCarpetRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPutAsync<EditCarpetRequest>(EditCarpetRequest.RouteTemplate, request);
        }
    }
}
