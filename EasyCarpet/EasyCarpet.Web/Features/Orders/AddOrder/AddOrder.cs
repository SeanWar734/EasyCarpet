using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Orders;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Orders.AddOrder
{
    public class AddOrder : IRequestHandler<AddOrderRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public AddOrder(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(AddOrderRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPostAsync<AddOrderRequest>(AddOrderRequest.RouteTemplate, request);
        }
    }
}
