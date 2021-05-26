using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;
using EasyCarpet.Domain.Models;
using EasyCarpet.Shared.Features.Carpets;
using EasyCarpet.Shared;
using System;

namespace EasyCarpet.Api.Features.Carpets
{
    public class AddCarpet : BaseAsyncEndpoint
        .WithRequest<AddCarpetRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;

        public AddCarpet(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("api/carpet")]
        [SwaggerOperation(
               Summary = "Add a new Carpet",
               Description = "Add a new Carpet",
               OperationId = "Carpet.Add",
               Tags = new[] { "CarpetEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(AddCarpetRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Carpet = new Carpet()
                {
                    Id = request.Carpet.Id,
                    Width = request.Carpet.Width,
                    Length = request.Carpet.Length,
                    Brand = request.Carpet.Brand,
                    Description = request.Carpet.Description,
                    Image = request.Carpet.Image,
                    Name = request.Carpet.Name,
                    SquareYardPrice = request.Carpet.SquareYardPrice,
                    Style = request.Carpet.Style,
                    CreatedDate = DateTime.Now
                };

                await _context.AddAsync(Carpet);
                await _context.SaveChangesAsync(cancellationToken);

                return Ok(new CommandResponse().Success());
            }
            else
            {
                return BadRequest(new CommandResponse().Errors(ModelState));
            }
        }
    }
}
