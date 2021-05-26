using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Carpets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Carpets
{
    public class GetCarpet : BaseAsyncEndpoint.WithRequest<Guid>
        .WithResponse<GetCarpetRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public GetCarpet(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/carpet/{id:guid}")]
        [SwaggerOperation(
          Summary = "Get one carpet",
          Description = "Get one carpet",
          OperationId = "Carpet.Get",
          Tags = new[] { "CarpetEndpoint" })]
        public override async Task<ActionResult<GetCarpetRequest.Response>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<CarpetFormModel>(CreateSql(), new { Id = id });

                return Ok(new GetCarpetRequest.Response(result.FirstOrDefault()));
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
                                ,c.[Image]
                          FROM [dbo].[Carpet] c
                          WHERE c.[Id] = @Id";
            }
        }
    }
}
