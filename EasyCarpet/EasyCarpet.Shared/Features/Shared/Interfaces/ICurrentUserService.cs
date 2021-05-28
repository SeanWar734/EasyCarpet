using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Shared.Interfaces
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}
