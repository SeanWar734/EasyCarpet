using Ardalis.ApiEndpoints;
using EasyCarpet.Shared.Features.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RepoDb;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Customers
{
    public class GetCustomer : BaseAsyncEndpoint.WithRequest<Guid>
        .WithResponse<GetCustomerRequest.Response>
    {
        private readonly IConfiguration _configuration;

        public GetCustomer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("api/customer/{id:guid}")]
        [SwaggerOperation(
          Summary = "Get one customer",
          Description = "Get one customer",
          OperationId = "Customer.Get",
          Tags = new[] { "CustomerEndpoint" })]
        public override async Task<ActionResult<GetCustomerRequest.Response>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")).EnsureOpen())
            {
                var result = await connection.ExecuteQueryAsync<CustomerFormModel>(CreateSql(), new { Id = id });

                return Ok(new GetCustomerRequest.Response(result.FirstOrDefault()));
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
                          FROM [dbo].[Customers] c
                          WHERE c.Id = @Id;";
            }
        }
    }
}
