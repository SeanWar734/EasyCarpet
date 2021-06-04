using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EasyCarpet.Shared;
using Microsoft.Extensions.Configuration;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Services
{
    public class UploadServiceBlobStorage : IUploadService
    {
        private readonly IConfiguration _configuration;

        public UploadServiceBlobStorage(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task UploadAsync(UploadRequest request)
        {
            if (request.Data == null) return;
            var streamData = new MemoryStream(request.Data);

            var container = new BlobContainerClient(_configuration["AzureStorage:ConnectionString"], _configuration["AzureStorage:Container"]);
            await container.CreateIfNotExistsAsync();

            await container.UploadBlobAsync(request.FileName, streamData);
        }
    }
}
