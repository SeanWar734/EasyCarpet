using EasyCarpet.Shared.Features.Customers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Customers.EditCustomer
{
    public class GetCustomer : IRequestHandler<GetCustomerRequest, GetCustomerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public GetCustomer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetCustomerRequest.Response> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{GetCustomerRequest.RouteTemplate}/{request.CustomerId}";
            return await _httpService.SendGetAsync<GetCustomerRequest.Response>(url);
        }
    }
}

