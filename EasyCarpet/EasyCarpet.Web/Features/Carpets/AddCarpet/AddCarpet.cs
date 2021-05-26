using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Carpets.AddCarpet
{
    public class AddCarpet : IRequestHandler<AddCarpetRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public AddCarpet(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(AddCarpetRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPostAsync<AddCarpetRequest>(AddCarpetRequest.RouteTemplate, request);
        }
    }
}
