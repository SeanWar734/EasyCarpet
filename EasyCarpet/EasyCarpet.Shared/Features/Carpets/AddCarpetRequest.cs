using MediatR;

namespace EasyCarpet.Shared.Features.Carpets
{
    public record AddCarpetRequest(CarpetFormModel Carpet) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/carpet";
    }
}
