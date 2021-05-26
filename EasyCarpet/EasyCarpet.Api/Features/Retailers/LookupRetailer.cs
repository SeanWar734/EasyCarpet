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
    public class LookupRetailer : BaseAsyncEndpoint.WithRequest<LookupRetailerRequest>
        .WithResponse<LookupRetailerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public LookupRetailer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/retailer/lookup")]
        [SwaggerOperation(
          Summary = "List Retailer",
          Description = "List Retailer",
          OperationId = "Retailer.List",
          Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<LookupRetailerRequest.Response>> HandleAsync([FromQuery] LookupRetailerRequest request, CancellationToken cancellationToken = default)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen();

            var result = await connection.ExecuteQueryAsync<LookupRetailerDto>(CreateSql(), new
            {
                Count = request.Count,
                Name = request.CompanyName
            });
            System.Console.WriteLine("break");
            return Ok(new LookupRetailerRequest.Response(result.ToList()));


            string CreateSql()
            {
                return @"SELECT TOP (@Count)
                            r.Id
                           ,r.CompanyName
                        FROM dbo.Retailers r
                        WHERE r.CompanyName LIKE '%' + @Name + '%';";
            }
        }
    }
}
