using MediatR;
using System;

namespace EasyCarpet.Shared.Features.Carpets
{
    public record GetCarpetRequest(Guid Id) : IRequest<GetCarpetRequest.Response>
    {
        public const string RouteTemplate = "/api/carpet";
        public record Response(CarpetFormModel Carpet);
    }
}
