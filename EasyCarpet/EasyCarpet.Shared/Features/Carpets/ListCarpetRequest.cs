using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Carpets
{
    public record ListCarpetRequest() : IRequest<ListCarpetRequest.Response>
    {
        public const string RouteTemplate = "/api/carpet";
        public record Response(List<ListCarpetDto> Carpet);
    }

    public record ListCarpetDto(Guid Id, string Name, decimal Width, decimal Length, decimal SquareYardPrice, string Brand, string Style, string Description, string Image);
}