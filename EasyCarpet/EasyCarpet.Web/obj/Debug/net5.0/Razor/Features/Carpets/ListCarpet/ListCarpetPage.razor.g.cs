#pragma checksum "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5983d7bcd6aefcd0c2915726bf2d16536a943bbb"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyCarpet.Web.Features.Carpets.ListCarpet
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
#line 2 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
using MediatR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
using EasyCarpet.Shared.Features.Carpets;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listcarpet")]
    public partial class ListCarpetPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                     10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", "pa-4");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "d-flex justify-space-between");
                __builder2.OpenComponent<MudBlazor.MudText>(6);
                __builder2.AddAttribute(7, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Carpet");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudFab>(12);
                __builder2.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                       Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                             Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                                                 AddContact

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudText>(17);
                __builder2.AddAttribute(18, "Class", "mb-8");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "List of Carpet");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
     if (_carpet == null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudProgressLinear>(21);
                __builder2.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                  Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Class", "my-7");
                __builder2.CloseComponent();
#nullable restore
#line 18 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __Blazor.EasyCarpet.Web.Features.Carpets.ListCarpet.ListCarpetPage.TypeInference.CreateMudTable_0(__builder2, 25, 26, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                          _carpet

#line default
#line hidden
#nullable disable
                , 27, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                          true

#line default
#line hidden
#nullable disable
                , 28, "Sort By", 29, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                , 30, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTh>(31);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(33);
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(35, "Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(37);
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(39, "Brand");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(41);
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(43, "Style");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(45);
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, "Width");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(49);
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(51, "Price per Yard");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(53);
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(55, "Description");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 56, (context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTd>(57);
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 33 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                     if (context.ImageFileName != null)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(59);
                        __builder4.AddAttribute(60, "Image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                            $"https://easycarpetstorageaccount.blob.core.windows.net/easycarpetblobcontainer/{context.ImageFileName}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "Style", "width:30px; height:30px");
                        __builder4.CloseComponent();
#nullable restore
#line 36 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(62);
                        __builder4.AddAttribute(63, "Image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                            "https://easycarpetstorageaccount.blob.core.windows.net/easycarpetblobcontainer/No_Image_Available.jpg"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "Style", "width:30px; height:30px");
                        __builder4.CloseComponent();
#nullable restore
#line 40 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                        }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(66);
                    __builder3.AddAttribute(67, "DataLabel", "Name");
                    __builder3.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudLink>(69);
                        __builder4.AddAttribute(70, "Href", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                         $"/viewcarpet/{context.Id}"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(72, 
#nullable restore
#line 42 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                                                        context.Name

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(74);
                    __builder3.AddAttribute(75, "DataLabel", "Brand");
                    __builder3.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(77, 
#nullable restore
#line 43 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                          context.Brand

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(79);
                    __builder3.AddAttribute(80, "DataLabel", "Style");
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(82, 
#nullable restore
#line 44 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                          context.Style

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(84);
                    __builder3.AddAttribute(85, "DataLabel", "Width");
                    __builder3.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(87, 
#nullable restore
#line 45 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                          context.Width

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(89);
                    __builder3.AddAttribute(90, "DataLabel", "Price per Yard");
                    __builder3.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(92, 
#nullable restore
#line 46 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                   context.SquareYardPrice

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(94);
                    __builder3.AddAttribute(95, "DataLabel", "Description");
                    __builder3.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(97, 
#nullable restore
#line 47 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
                                                context.Description

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
#nullable restore
#line 50 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Carpets\ListCarpet\ListCarpetPage.razor"
       
    private IEnumerable<ListCarpetDto> _carpet;

    protected override async Task OnInitializedAsync()
    {
        _carpet = (await _mediator.Send(new ListCarpetRequest())).Carpet;
    }

    private void AddContact()
    {
        _navigationManager.NavigateTo("/addcarpet");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator _mediator { get; set; }
    }
}
namespace __Blazor.EasyCarpet.Web.Features.Carpets.ListCarpet.ListCarpetPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "SortLabel", __arg2);
        __builder.AddAttribute(__seq3, "Dense", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
