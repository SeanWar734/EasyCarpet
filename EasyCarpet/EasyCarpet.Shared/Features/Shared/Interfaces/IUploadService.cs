using EasyCarpet.Shared.Features.Shared.Requests;
using EasyCarpet.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Shared.Interfaces
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}
