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
    public class SearchRetailer : BaseAsyncEndpoint
        .WithRequest<SearchRetailerRequest>
        .WithResponse<SearchRetailerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public SearchRetailer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/retailer/searches")]
        [SwaggerOperation(
          Summary = "Search Retailers",
          Description = "Search Retailers",
          OperationId = "Retailer.Search",
          Tags = new[] { "RetailerEndpoint" })]
        public override async Task<ActionResult<SearchRetailerRequest.Response>> HandleAsync([FromQuery] SearchRetailerRequest request, CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListRetailerDto>(CreateSql(),
                    new
                    {
                        CompanyName = request.CompanyName,
                        City = request.City
                    });

                return Ok(new SearchRetailerRequest.Response(result.ToList()));
            }

            string CreateSql()
            {
                return @$"Select * from dbo.Retailers Where {CreateWhereClause(request)}";
            }

            string AddAnd(string whereClause)
            {
                return string.IsNullOrEmpty(whereClause) ? string.Empty : $" AND ";
            }

            string CreateWhereClause(SearchRetailerRequest request)
            {
                var whereClause = string.Empty;

                if (!string.IsNullOrWhiteSpace(request.CompanyName))
                {
                    whereClause = $"{whereClause} {AddAnd(whereClause)} (CompanyName LIKE '%' + @CompanyName + '%')";
                }
                if (!string.IsNullOrWhiteSpace(request.City))
                {
                    whereClause = $"{whereClause} {AddAnd(whereClause)} (City LIKE '%' + @City + '%')";
                }

                return whereClause;
            }
        }
    }
}
