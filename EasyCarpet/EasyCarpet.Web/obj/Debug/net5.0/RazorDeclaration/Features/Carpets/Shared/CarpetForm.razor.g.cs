// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EasyCarpet.Web.Features.Carpets.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using EasyCarpet.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using EasyCarpet.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using EasyCarpet.Web.Features.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using EasyCarpet.Web.Features.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using EasyCarpet.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\_Imports.razor"
using EasyCarpet.Web.Features.Carpets.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\Shared\CarpetForm.razor"
using EasyCarpet.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\Shared\CarpetForm.razor"
using EasyCarpet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\Shared\CarpetForm.razor"
using EasyCarpet.Shared.Features.Carpets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\Shared\CarpetForm.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class CarpetForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\Shared\CarpetForm.razor"
       

    private ServerSideValidator _serverSideValidator;
    private bool _isEditing = false;
    private string _transactionMode = "Adding a Carpet";
    private CarpetFormModel _carpet = new CarpetFormModel();

    [Inject] private Microsoft.Extensions.Localization.IStringLocalizer<CarpetForm> localizer { get; set; }

    [Parameter] public CarpetFormModel Carpet { get; set; }
    [Parameter] public bool IsProcessing { get; set; } = false;
    [Parameter] public CommandResponse CommandResponse { get; set; }
    [Parameter] public Action OnCancel { get; set; }
    [Parameter] public Func<Guid, Task> OnDelete { get; set; }
    [Parameter] public Func<CarpetFormModel, Task> OnSubmit { get; set; }

    public IBrowserFile file { get; set; }

    private void Cancel() => OnCancel();
    private void Delete() => OnDelete(_carpet.Id);

    private async Task HandleSubmitAsync()
    {
        await OnSubmit(_carpet);
    }

    protected override void OnParametersSet()
    {
        if (Carpet != null)
        {
            _carpet.Id = Carpet.Id;
            _carpet.Brand = Carpet.Brand;
            _carpet.Description = Carpet.Description;
            _carpet.Length = Carpet.Length;
            _carpet.Name = Carpet.Name;
            _carpet.SquareYardPrice = Carpet.SquareYardPrice;
            _carpet.Style = Carpet.Style;
            _carpet.Width = Carpet.Width;

            _isEditing = true;
            _transactionMode = "Editing a Carpet";
        }


        if (CommandResponse != null && !CommandResponse.IsSuccessful)
        {
            _serverSideValidator.DisplayErrors(CommandResponse.Errors);
        }
    }

    private async Task UploadFiles(InputFileChangeEventArgs e)
    {
        file = e.File;
        if (file != null)
        {
            var buffer = new byte[file.Size];
            var extension = Path.GetExtension(file.Name);
            var Document = await file.OpenReadStream(file.Size).ReadAsync(buffer);
            _carpet.UploadRequest = new UploadRequest { Data = buffer, Extension = extension };
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
