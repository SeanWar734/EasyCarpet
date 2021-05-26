using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Installers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Installers
{
    public class ListInstaller : BaseAsyncEndpoint.WithoutRequest
        .WithResponse<ListInstallerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public ListInstaller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/installers")]
        [SwaggerOperation(
          Summary = "Get a list of installers",
          Description = "Get a list of installers",
          OperationId = "Installer.List",
          Tags = new[] { "InstallerEndpoint" })]
        public override async Task<ActionResult<ListInstallerRequest.Response>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListInstallerDto>(CreateSql());

                return Ok(new ListInstallerRequest.Response(result.ToList()));
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
                        ON i.RetailerId = r.Id;";
            }
        }
    }
}
