using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Customers;
using EasyCarpet.Web.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Web.Features.Customers.EditCustomer
{
    public class EditCustomer : IRequestHandler<EditCustomerRequest, CommandResponse>
    {
        private readonly IHttpService _httpService;

        public EditCustomer(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<CommandResponse> Handle(EditCustomerRequest request, CancellationToken cancellationToken)
        {
            return await _httpService.SendPutAsync<EditCustomerRequest>(EditCustomerRequest.RouteTemplate, request);
        }
    }
}
