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
using EasyCarpet.Api.Services;

namespace EasyCarpet.Api.Features.Carpets
{
    public class AddCarpet : BaseAsyncEndpoint
        .WithRequest<AddCarpetRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;
        private readonly IUploadService _uploadService;

        public AddCarpet(AppDbContext context, IUploadService uploadService)
        {
            _context = context;
            _uploadService = uploadService;
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
                    Width = request.Carpet.Width,
                    Length = request.Carpet.Length,
                    Brand = request.Carpet.Brand,
                    Description = request.Carpet.Description,
                    Name = request.Carpet.Name,
                    SquareYardPrice = request.Carpet.SquareYardPrice,
                    Style = request.Carpet.Style,
                    ImageUrl = request.Carpet.ImageUrl,
                    CreatedDate = DateTime.Now
                };

                var uploadRequest = request.Carpet.UploadRequest;
                if (uploadRequest != null)
                {
                    uploadRequest.FileName = $"{Carpet.Id}{uploadRequest.Extension}";
                    Carpet.ImageUrl = await _uploadService.UploadAsync(uploadRequest);
                }

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
