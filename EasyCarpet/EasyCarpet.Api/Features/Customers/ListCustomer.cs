using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Customers
{
    public class ListCustomer : BaseAsyncEndpoint.WithoutRequest
        .WithResponse<ListCustomerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public ListCustomer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/customers")]
        [SwaggerOperation(
          Summary = "Get a list of customers",
          Description = "Get a list of customers",
          OperationId = "Customer.List",
          Tags = new[] { "CustomerEndpoint" })]
        public override async Task<ActionResult<ListCustomerRequest.Response>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var connectitonString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<ListCustomerDto>(CreateSql());

                return Ok(new ListCustomerRequest.Response(result.ToList()));
            }

            string CreateSql()
            {
                return @"SELECT  
                               c.[Id]
                              ,c.[FirstName]
                              ,c.[LastName]
                              ,c.[Address]
                              ,c.[City]
                              ,c.[State]
                              ,c.[PhoneNumber]
                          FROM [dbo].[Customers] c;";
            }
        }
    }
}
