using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Orders;
using EasyCarpet.Shared.Features.Retailers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Orders
{
    public class GetOrder : BaseAsyncEndpoint.WithRequest<Guid>
        .WithResponse<GetOrderRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public GetOrder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/order/{id:guid}")]
        [SwaggerOperation(
          Summary = "Get one order",
          Description = "Get one order",
          OperationId = "Order.Get",
          Tags = new[] { "OrderEndpoint" })]
        public override async Task<ActionResult<GetOrderRequest.Response>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<GetOrderDto>(CreateSql(), new { Id = id });

                return Ok(new GetOrderRequest.Response(result.FirstOrDefault()?.ToModel()));
            }

            string CreateSql()
            {
                return @"SELECT 
                               o.[Id]
                              ,o.[CustomerId]
                              ,o.[RetailerId]
                              ,o.[InstallerId]
                              ,o.[CarpetId]
                              ,o.[Total]
                              ,r.[CompanyName] as RetailerName
                          FROM [dbo].[Orders] o
                          JOIN [dbo].[Retailers] r
                          ON o.RetailerId = r.Id
                          WHERE o.Id = @Id;";
            }
        }

        record GetOrderDto(Guid Id, Guid CustomerId, Guid RetailerId, Guid InstallerId, Guid CarpetId, Decimal Total, string RetailerName)
        {
            public OrderFormModel ToModel()
            {
                return new OrderFormModel
                {
                    Id = this.Id,
                    CarpetId = this.CarpetId,
                    CustomerId = this.CustomerId,
                    InstallerId = this.InstallerId,
                    Total = this.Total,
                    Retailer = new LookupRetailerDto(RetailerId, RetailerName)
                };
            }
        }
    }
}
