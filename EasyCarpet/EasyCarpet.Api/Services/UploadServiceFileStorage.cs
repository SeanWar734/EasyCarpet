using EasyCarpet.Shared;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Services
{
    public class UploadServiceFileStorage : IUploadService
    {
        public async Task UploadAsync(UploadRequest request)
        {
            if (request.Data == null) return;
            var streamData = new MemoryStream(request.Data);
            if (streamData.Length > 0)
            {
                var folder = "Images";
                var folderName = Path.Combine("Files", folder);
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                bool exists = System.IO.Directory.Exists(pathToSave);
                if (!exists)
                    System.IO.Directory.CreateDirectory(pathToSave);

                var fileName = request.FileName.Trim('"');

                var fullPath = Path.Combine(pathToSave, fileName);

                var resizeOptions = new ResizeOptions
                {
                    Mode = ResizeMode.Pad,
                    Size = new Size(220, 220)
                };

                try
                {
                    using var image = Image.Load(request.Data);
                    image.Mutate(_ => _.Resize(resizeOptions));
                    await image.SaveAsJpegAsync(fullPath);
                }
                catch (System.Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
