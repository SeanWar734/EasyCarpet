using EasyCarpet.Shared.Features.Customers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Customers.ListCustomer
{
    public class ListCustomer : IRequestHandler<ListCustomerRequest, ListCustomerRequest.Response>
    {
        private readonly IHttpService _httpService;

        public ListCustomer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ListCustomerRequest.Response> Handle(ListCustomerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendGetAsync<ListCustomerRequest.Response>(ListCustomerRequest.RouteTemplate);
        }
    }
}

