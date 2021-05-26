using MediatR;

namespace EasyCarpet.Shared.Features.Retailers
{
    public record AddRetailerRequest(RetailerFormModel Retailer) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/retailer";
    }
}
