using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Installers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Installers
{
    public class GetInstaller : BaseAsyncEndpoint.WithRequest<Guid>
        .WithResponse<GetInstallerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public GetInstaller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/installer/{id:guid}")]
        [SwaggerOperation(
          Summary = "Get one installer",
          Description = "Get one installer",
          OperationId = "Installer.Get",
          Tags = new[] { "InstallerEndpoint" })]
        public override async Task<ActionResult<GetInstallerRequest.Response>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<InstallerFormModel>(CreateSql(), new { Id = id });

                return Ok(new GetInstallerRequest.Response(result.FirstOrDefault()));
            }

            string CreateSql()
            {
                return @"SELECT
                             i.Id
                            ,i.RetailerId
                            ,r.CompanyName as RetailerName
                            ,i.FirstName
                            ,i.LastName
                            ,i.PhoneNumber
                            ,i.SquareYardPrice
                            ,i.Area
                        FROM dbo.Installers i
                        JOIN dbo.Retailers r
                        ON i.RetailerId = r.Id
                        WHERE i.Id = @Id;";
            }
        }
    }
}
