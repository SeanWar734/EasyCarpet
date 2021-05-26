using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Customers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Customers.EditCustomer
{
    public class DeleteCustomer : IRequestHandler<DeleteCustomerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public DeleteCustomer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            var url = $"{DeleteCustomerRequest.RouteTemplate}/{request.CustomerId}";
            return await _httpService.SendDeleteWithResponseAsync(url);
        }
    }
}
