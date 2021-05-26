using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Carpets
{
    public class SearchCarpetRequest : IRequest<SearchCarpetRequest.Response>
    {
        public const string RouteTemplate = "/api/carpet/searches";
        public record Response(List<ListCarpetDto> Carpet);

        public string Brand { get; set; }
        public string Name { get; set; }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Brand) && string.IsNullOrEmpty(Name);
        }
    }
}
