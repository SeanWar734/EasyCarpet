using EasyCarpet.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCarpet.Api.Services
{
    public interface IUploadService
    {
        Task<string> UploadAsync(UploadRequest request);
    }
}
