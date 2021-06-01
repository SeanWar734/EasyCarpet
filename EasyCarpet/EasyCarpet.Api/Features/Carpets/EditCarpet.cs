using Ardalis.ApiEndpoints;
using EasyCarpet.Api.Extensions;
using EasyCarpet.Api.Services;
using EasyCarpet.Domain;
using EasyCarpet.Shared;
using EasyCarpet.Shared.Features.Carpets;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Features.Carpets
{
    public class EditCarpet : BaseAsyncEndpoint
        .WithRequest<EditCarpetRequest>
        .WithResponse<CommandResponse>
    {
        private readonly AppDbContext _context;
        private readonly IUploadService _uploadService;

        public EditCarpet(AppDbContext context, IUploadService uploadService)
        {
            _context = context;
            _uploadService = uploadService;
        }

        [HttpPut("api/carpet")]
        [SwaggerOperation(
               Summary = "Edit a carpet",
               Description = "Edit a carpet",
               OperationId = "Carpet.Edit",
               Tags = new[] { "CarpetEndpoint" })]
        public override async Task<ActionResult<CommandResponse>> HandleAsync(EditCarpetRequest request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var Carpet = await _context.Carpets.FindAsync(request.Carpet.Id);

                if (Carpet != null)
                {
                    Carpet.Id = request.Carpet.Id;
                    Carpet.Name = request.Carpet.Name;
                    Carpet.Brand = request.Carpet.Brand;
                    Carpet.Description = request.Carpet.Description;
                    Carpet.Width = request.Carpet.Width;
                    Carpet.Length = request.Carpet.Length;
                    Carpet.SquareYardPrice = request.Carpet.SquareYardPrice;
                    Carpet.Style = request.Carpet.Style;
                    Carpet.ImageUrl = request.Carpet.ImageUrl;
                    Carpet.ModifiedDate = DateTime.Now;

                    var uploadRequest = request.Carpet.UploadRequest;
                    if (uploadRequest != null)
                    {
                        uploadRequest.FileName = $"{Carpet.Id}{uploadRequest.Extension}";
                        Carpet.ImageUrl = await _uploadService.UploadAsync(uploadRequest);
                    }

                    await _context.SaveChangesAsync(cancellationToken);
                }

                return Ok(new CommandResponse().Success());
            }
            else
            {
                return BadRequest(new CommandResponse().Errors(ModelState));
            }
        }
    }
}
