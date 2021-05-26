using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Orders
{
    public class ListOrder : BaseAsyncEndpoint.WithoutRequest
        .WithResponse<ListOrderRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public ListOrder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/orders")]
        [SwaggerOperation(
          Summary = "List all orders",
          Description = "List all orders",
          OperationId = "Order.List",
          Tags = new[] { "OrderEndpoint" })]
        public override async Task<ActionResult<ListOrderRequest.Response>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListOrderDto>(CreateSql());

                return Ok(new ListOrderRequest.Response(result.ToList()));
            }

            string CreateSql()
            {
                return @"SELECT o.[Id]
                              ,cu.FirstName AS CustomerFirstName
	                          ,cu.LastName AS CustomerLastName
                              ,r.CompanyName AS RetailerName
                              ,i.FirstName AS InstallerFirstName
	                          ,i.LastName AS InstallerLastName
                              ,ca.Name AS CarpetName
                              ,o.[Total]
                          FROM [dbo].[Orders] o
                          JOIN dbo.Customers cu
                          ON o.CustomerId = cu.Id
                          JOIN dbo.Retailers r
                          ON o.RetailerId = r.Id
                          JOIN dbo.Installers i
                          ON o.InstallerId = i.Id
                          JOIN dbo.Carpet ca
                          ON o.CarpetId = ca.Id;";
            }
        }
    }
}
