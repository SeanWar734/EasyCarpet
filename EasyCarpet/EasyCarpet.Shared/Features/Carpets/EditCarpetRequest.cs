using MediatR;

namespace EasyCarpet.Shared.Features.Carpets
{
    public record EditCarpetRequest(CarpetFormModel Carpet) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/carpet";
    }
}
