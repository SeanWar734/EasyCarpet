#pragma checksum "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284f3bdce564a8995f537006992f0f12d36eca42"
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
#line 1 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
using EasyCarpet.Shared.Features.Retailers;

#line default
#line hidden
#nullable disable
    public partial class SearchRetailerForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                  SearchRetailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                 HandleSubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCard>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(6);
                    __builder3.AddAttribute(7, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(8);
                        __builder4.AddAttribute(9, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(11, "Search Retailer");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(12, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudText>(13);
                        __builder4.AddAttribute(14, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                 Color.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(18);
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.EasyCarpet.Web.Features.Retailers.SearchRetailer.SearchRetailerForm.TypeInference.CreateMudTextField_0(__builder4, 20, 21, "Company Name", 22, 
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                        , 23, 
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                                                                       Margin.Normal

#line default
#line hidden
#nullable disable
                        , 24, 
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                 ()=> SearchRetailer.CompanyName

#line default
#line hidden
#nullable disable
                        , 25, 
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                       SearchRetailer.CompanyName

#line default
#line hidden
#nullable disable
                        , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SearchRetailer.CompanyName = __value, SearchRetailer.CompanyName)));
                        __builder4.AddMarkupContent(27, "\r\n            ");
                        __Blazor.EasyCarpet.Web.Features.Retailers.SearchRetailer.SearchRetailerForm.TypeInference.CreateMudTextField_1(__builder4, 28, 29, "City", 30, 
#nullable restore
#line 16 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                                  Variant.Text

#line default
#line hidden
#nullable disable
                        , 31, 
#nullable restore
#line 16 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                                                        Margin.Normal

#line default
#line hidden
#nullable disable
                        , 32, 
#nullable restore
#line 17 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                 ()=> SearchRetailer.City

#line default
#line hidden
#nullable disable
                        , 33, 
#nullable restore
#line 16 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                       SearchRetailer.City

#line default
#line hidden
#nullable disable
                        , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SearchRetailer.City = __value, SearchRetailer.City)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(36);
                    __builder3.AddAttribute(37, "Class", "d-flex justify-end py-2 px-1");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudButton>(39);
                        __builder4.AddAttribute(40, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 20 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                       Color.Default

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                               Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(43, "Class", "ml-4");
                        __builder4.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(45, "Cancel");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudButton>(47);
                        __builder4.AddAttribute(48, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                   ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                                       Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "Class", "ml-2");
                        __builder4.AddAttribute(52, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
                                                                                                                             IsProcessing

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(54, "Search");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\SearchRetailer\SearchRetailerForm.razor"
       


    [Parameter] public bool IsProcessing { get; set; } = false;

    [Parameter] public SearchRetailerRequest SearchRetailer { get; set; }
    [Parameter] public Func<SearchRetailerRequest, Task> OnSubmit { get; set; }
    [Parameter] public Action OnCancel { get; set; }


    private async Task HandleSubmitAsync() => await OnSubmit(SearchRetailer);

    private void Cancel() => OnCancel();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.EasyCarpet.Web.Features.Retailers.SearchRetailer.SearchRetailerForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "For", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "For", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
