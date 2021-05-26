using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Orders;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Orders.EditOrder
{
    public class EditOrder : IRequestHandler<EditOrderRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public EditOrder(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(EditOrderRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPutAsync<EditOrderRequest>(EditOrderRequest.RouteTemplate, request);
        }
    }
}
