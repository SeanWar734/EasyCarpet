using MediatR;
using System;
using System.Collections.Generic;

namespace EasyCarpet.Shared.Features.Retailers
{
    public class SearchRetailerRequest : IRequest<SearchRetailerRequest.Response>
    {
        public const string RouteTemplate = "/api/retailer/searches";
        public record Response(List<ListRetailerDto> Retailers);

        public string CompanyName { get; set; }
        public string City { get; set; }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(City) && string.IsNullOrEmpty(CompanyName);
        }
    }
}
