using EasyCarpet.Shared.Features.Orders;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Orders.EditOrder
{
    public class GetOrder : IRequestHandler<GetOrderRequest, GetOrderRequest.Response>
    {
        private readonly IHttpService _httpService;

        public GetOrder(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetOrderRequest.Response> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var url = $"{GetOrderRequest.RouteTemplate}/{request.Id}";
            return await _httpService.SendGetAsync<GetOrderRequest.Response>(url);
        }
    }
}

