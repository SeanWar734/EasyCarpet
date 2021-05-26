using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Orders;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Orders.EditOrder
{
    public class DeleteOrder : IRequestHandler<DeleteOrderRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public DeleteOrder(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(DeleteOrderRequest request, CancellationToken cancellationToken)
        {
            var url = $"{DeleteOrderRequest.RouteTemplate}/{request.OrderId}";
            return await _httpService.SendDeleteWithResponseAsync(url);
        }
    }
}
