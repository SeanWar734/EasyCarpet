using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Customers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Customers.AddCustomer
{
    public class AddCustomer : IRequestHandler<AddCustomerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public AddCustomer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPostAsync<AddCustomerRequest>(AddCustomerRequest.RouteTemplate, request);
        }
    }
}
