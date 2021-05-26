using Ardalis.ApiEndpoints;
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

namespace EasyCarpet.Api.Features.Retailers
{
    public class GetRetailer : BaseAsyncEndpoint.WithRequest<Guid>
        .WithResponse<GetRetailerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public GetRetailer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/retailer/{id:guid}")]
        [SwaggerOperation(
          Summary = "Get a single retailer",
          Description = "Get a single retailer",
          OperationId = "Retailer.Get",
          Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<GetRetailerRequest.Response>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<RetailerFormModel>(CreateSql(), new { Id = id });

                return Ok(new GetRetailerRequest.Response(result.FirstOrDefault()));
            }

            string CreateSql()
            {
                return @"SELECT
                             r.Id
                            ,r.CompanyName
                            ,r.Address
                            ,r.City
                            ,r.State
                            ,r.PhoneNumber
                            ,r.Description
                        FROM dbo.Retailers r
                        WHERE r.Id = @Id;";
            }
        }
    }
}
