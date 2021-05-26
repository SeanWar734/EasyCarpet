using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Carpets
{
    public record DeleteCarpetRequest(Guid CarpetId) : IRequest<CommandResponse>
    {
        public const string RouteTemplate = "/api/carpet";
    }
}
