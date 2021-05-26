using EasyCarpet.Shared.Features.Orders;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Orders.ListOrder
{
    public class ListOrder : IRequestHandler<ListOrderRequest, ListOrderRequest.Response>
    {
        private readonly IHttpService _httpService;

        public ListOrder(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ListOrderRequest.Response> Handle(ListOrderRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendGetAsync<ListOrderRequest.Response>(ListOrderRequest.RouteTemplate);
        }
    }
}

