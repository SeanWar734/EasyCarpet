using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Carpets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Carpets
{
    public class SearchCarpet : BaseAsyncEndpoint
        .WithRequest<SearchCarpetRequest>
        .WithResponse<SearchCarpetRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public SearchCarpet(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/carpet/searches")]
        [SwaggerOperation(
          Summary = "Search carpet",
          Description = "Search carpet",
          OperationId = "Carpet.Search",
          Tags = new[] { "CarpetEndpoint" })]
        public override async Task<ActionResult<SearchCarpetRequest.Response>> HandleAsync([FromQuery] SearchCarpetRequest request, CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListCarpetDto>(CreateSql(),
                    new
                    {
                        Name = request.Name,
                        Brand = request.Brand
                    });

                return Ok(new SearchCarpetRequest.Response(result.ToList()));
            }

            string CreateSql()
            {
                return @$"Select * from dbo.carpet Where {CreateWhereClause(request)}";
            }

            string AddAnd(string whereClause)
            {
                return string.IsNullOrEmpty(whereClause) ? string.Empty : $" AND ";
            }

            string CreateWhereClause(SearchCarpetRequest request)
            {
                var whereClause = string.Empty;

                if (!string.IsNullOrWhiteSpace(request.Name))
                {
                    whereClause = $"{whereClause} {AddAnd(whereClause)} (Name LIKE '%' + @Name + '%')";
                }
                if (!string.IsNullOrWhiteSpace(request.Brand))
                {
                    whereClause = $"{whereClause} {AddAnd(whereClause)} (Brand LIKE '%' + @Brand + '%')";
                }

                return whereClause;
            }
        }
    }
}
