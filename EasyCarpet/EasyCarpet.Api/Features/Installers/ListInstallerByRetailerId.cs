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
    public class ListInstallerByRetailerId : BaseAsyncEndpoint.WithRequest<Guid>
        .WithResponse<ListInstallerByRetailerIdRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public ListInstallerByRetailerId(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/installers/retailer/{RetailerId:guid}")]
        [SwaggerOperation(
          Summary = "List all installers by retailer Id",
          Description = "List all installer by RetailerId",
          OperationId = "Installer.ListByRetailer",
          Tags = new[] { "InstallerEndpoint" })]
        public override async Task<ActionResult<ListInstallerByRetailerIdRequest.Response>> HandleAsync(Guid RetailerId, CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListInstallerDto>(CreateSql(), new { RetailerId = RetailerId });

                return Ok(new ListInstallerByRetailerIdRequest.Response(result.ToList()));
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
                        WHERE i.RetailerId = @RetailerId;";
            }
        }
    }
}
