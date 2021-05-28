using EasyCarpet.Shared.Features.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCarpet.Shared.Features.Shared.Interfaces
{
    public interface IDocumentManager
    {
        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);

    }
}
