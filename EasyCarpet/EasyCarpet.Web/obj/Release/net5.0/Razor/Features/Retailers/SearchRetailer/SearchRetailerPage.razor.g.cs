#pragma checksum "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc061cccbca1ce66d9237f3925063d75c3021781"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyCarpet.Web.Features.Retailers.SearchRetailer
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
#line 1 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\_Imports.razor"
using EasyCarpet.Web.Features.Retailers.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
using MediatR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
using EasyCarpet.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
using EasyCarpet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
using EasyCarpet.Shared.Features.Retailers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/searchretailer")]
    public partial class SearchRetailerPage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
 if (_isProcessing)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressLinear>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                              Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", "my-7");
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
 if (_showResults)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<EasyCarpet.Web.Features.Retailers.SearchRetailer.SearchRetailerResult>(4);
            __builder.AddAttribute(5, "Retailers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<EasyCarpet.Shared.Features.Retailers.ListRetailerDto>>(
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                     _retailers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnBackToSearch", new System.Action(
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                                                 BackToSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<EasyCarpet.Web.Features.Retailers.SearchRetailer.SearchRetailerForm>(7);
            __builder.AddAttribute(8, "SearchRetailer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EasyCarpet.Shared.Features.Retailers.SearchRetailerRequest>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                        _searchRetailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnCancel", new System.Action(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                                                   Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnSubmit", new System.Func<EasyCarpet.Shared.Features.Retailers.SearchRetailerRequest, System.Threading.Tasks.Task>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                                                                     Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "IsProcessing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
                                                                                                           _isProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 22 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerPage.razor"
       
    private bool _isProcessing = false;
    private bool _showResults = false;

    private SearchRetailerRequest _searchRetailer = new SearchRetailerRequest();
    private List<ListRetailerDto> _retailers { get; set; } = new List<ListRetailerDto>();

    protected async override Task OnInitializedAsync()
    {
        UpdateSearchModelFromQueryParameters();
        if (!_searchRetailer.IsEmpty())
        {
            await GetSearchResults();
            _showResults = true;
        }

        _navigationManager.LocationChanged += HandleLocationChanged;

    }

    private void UpdateSearchModelFromQueryParameters()
    {
        var uri = _navigationManager.Uri;
        _navigationManager.TryGetQueryString<string>("CompanyName", out var CompanyName);
        _navigationManager.TryGetQueryString<string>("City", out var City);

        _searchRetailer.CompanyName = CompanyName;
        _searchRetailer.City = City;
    }

    private async Task Submit(SearchRetailerRequest searchRetailer)
    {
        _navigationManager.NavigateTo($"/searchretailer/?{searchRetailer.ToUrl()}");
    }

    private void HandleLocationChanged(object sender, LocationChangedEventArgs args)
    {
        UpdateSearchModelFromQueryParameters();
        if (!_searchRetailer.IsEmpty())
        {
            GetSearchResults();
            _showResults = true;
        }
        else
        {
            _retailers = new List<ListRetailerDto>();
            _showResults = false;
        }

        StateHasChanged();
    }

    private async Task GetSearchResults()
    {
        _isProcessing = true;
        StateHasChanged();

        _retailers = (await _mediator.Send(_searchRetailer)).Retailers;

        _isProcessing = false;
        _showResults = true;

        StateHasChanged();

    }

    private void Cancel()
    {
        _navigationManager.NavigateTo("/");
    }

    private void BackToSearch()
    {
        _showResults = false;
        _retailers = new List<ListRetailerDto>();
        StateHasChanged();
    }

    public void Dispose() => _navigationManager.LocationChanged -= HandleLocationChanged;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator _mediator { get; set; }
    }
}
#pragma warning restore 1591