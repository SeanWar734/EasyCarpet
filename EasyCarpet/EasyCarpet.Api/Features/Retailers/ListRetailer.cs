using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Retailers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Retailers
{
    public class ListRetailer : BaseAsyncEndpoint.WithoutRequest
        .WithResponse<ListRetailerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public ListRetailer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/retailers")]
        [SwaggerOperation(
          Summary = "List all retailers",
          Description = "List all retailers",
          OperationId = "Retailer.List",
          Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<ListRetailerRequest.Response>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListRetailerDto>(CreateSql());

                return Ok(new ListRetailerRequest.Response(result.ToList()));
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
                        FROM dbo.Retailers r;";
            }
        }
    }
}
