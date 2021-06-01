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
    public class ListCarpet : BaseAsyncEndpoint.WithoutRequest
        .WithResponse<ListCarpetRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public ListCarpet(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/carpet")]
        [SwaggerOperation(
          Summary = "Get a list of carpet",
          Description = "Get a list of carpet",
          OperationId = "Carpet.List",
          Tags = new[] { "CarpetEndpoint" })]
        public override async Task<ActionResult<ListCarpetRequest.Response>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListCarpetDto>(CreateSql());

                return Ok(new ListCarpetRequest.Response(result.ToList()));
            }

            string CreateSql()
            {
                return @"SELECT  c.[Id]
                                ,c.[Width]
                                ,c.[Length]
                                ,c.[SquareYardPrice]
                                ,c.[Description]
                                ,c.[Name]
                                ,c.[Brand]
                                ,c.[Style]
                                ,c.[ImageUrl]
                          FROM [dbo].[Carpet] c";
            }
        }
    }
}
