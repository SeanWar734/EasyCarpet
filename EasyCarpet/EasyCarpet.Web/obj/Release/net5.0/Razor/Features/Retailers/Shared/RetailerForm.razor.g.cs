#pragma checksum "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9522bedb0984a3fa96bf9d69700da1cde1ff6d0b"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyCarpet.Web.Features.Retailers.Shared
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
#line 1 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
using EasyCarpet.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
using EasyCarpet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
using EasyCarpet.Shared.Features.Retailers;

#line default
#line hidden
#nullable disable
    public partial class RetailerForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
 if (_retailer != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                      _retailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                HandleSubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<EasyCarpet.Web.Helpers.ServerSideValidator>(6);
                __builder2.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                   _serverSideValidator = (EasyCarpet.Web.Helpers.ServerSideValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudCard>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(11);
                    __builder3.AddAttribute(12, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(13);
                        __builder4.AddAttribute(14, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(16, 
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                             _transactionMode

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudText>(18);
                        __builder4.AddAttribute(19, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     Color.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm.TypeInference.CreateMudTextField_0(__builder4, 25, 26, "Company Name", 27, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                Variant.Text

#line default
#line hidden
#nullable disable
                        , 28, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                                      Margin.Normal

#line default
#line hidden
#nullable disable
                        , 29, 
#nullable restore
#line 22 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     ()=> _retailer.CompanyName

#line default
#line hidden
#nullable disable
                        , 30, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                           _retailer.CompanyName

#line default
#line hidden
#nullable disable
                        , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _retailer.CompanyName = __value, _retailer.CompanyName)));
                        __builder4.AddMarkupContent(32, "\r\n                ");
                        __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm.TypeInference.CreateMudTextField_1(__builder4, 33, 34, "Address", 35, 
#nullable restore
#line 23 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                       Variant.Text

#line default
#line hidden
#nullable disable
                        , 36, 
#nullable restore
#line 23 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                             Margin.Normal

#line default
#line hidden
#nullable disable
                        , 37, 
#nullable restore
#line 24 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     ()=> _retailer.Address

#line default
#line hidden
#nullable disable
                        , 38, 
#nullable restore
#line 23 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                           _retailer.Address

#line default
#line hidden
#nullable disable
                        , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _retailer.Address = __value, _retailer.Address)));
                        __builder4.AddMarkupContent(40, "\r\n                ");
                        __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm.TypeInference.CreateMudTextField_2(__builder4, 41, 42, "City", 43, 
#nullable restore
#line 25 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                        , 44, 
#nullable restore
#line 25 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                       Margin.Normal

#line default
#line hidden
#nullable disable
                        , 45, 
#nullable restore
#line 26 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     ()=> _retailer.City

#line default
#line hidden
#nullable disable
                        , 46, 
#nullable restore
#line 25 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                           _retailer.City

#line default
#line hidden
#nullable disable
                        , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _retailer.City = __value, _retailer.City)));
                        __builder4.AddMarkupContent(48, "\r\n                ");
                        __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm.TypeInference.CreateMudTextField_3(__builder4, 49, 50, "State", 51, 
#nullable restore
#line 27 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                   Variant.Text

#line default
#line hidden
#nullable disable
                        , 52, 
#nullable restore
#line 27 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                         Margin.Normal

#line default
#line hidden
#nullable disable
                        , 53, 
#nullable restore
#line 28 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     ()=> _retailer.State

#line default
#line hidden
#nullable disable
                        , 54, 
#nullable restore
#line 27 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                           _retailer.State

#line default
#line hidden
#nullable disable
                        , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _retailer.State = __value, _retailer.State)));
                        __builder4.AddMarkupContent(56, "\r\n                ");
                        __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm.TypeInference.CreateMudTextField_4(__builder4, 57, 58, "Phone Number", 59, 
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                Variant.Text

#line default
#line hidden
#nullable disable
                        , 60, 
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                                      Margin.Normal

#line default
#line hidden
#nullable disable
                        , 61, 
#nullable restore
#line 30 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     ()=> _retailer.PhoneNumber

#line default
#line hidden
#nullable disable
                        , 62, 
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                           _retailer.PhoneNumber

#line default
#line hidden
#nullable disable
                        , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _retailer.PhoneNumber = __value, _retailer.PhoneNumber)));
                        __builder4.AddMarkupContent(64, "\r\n                ");
                        __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm.TypeInference.CreateMudTextField_5(__builder4, 65, 66, "Description", 67, 
#nullable restore
#line 31 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                               Variant.Text

#line default
#line hidden
#nullable disable
                        , 68, 
#nullable restore
#line 31 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                                     Margin.Normal

#line default
#line hidden
#nullable disable
                        , 69, 
#nullable restore
#line 32 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                     ()=> _retailer.Description

#line default
#line hidden
#nullable disable
                        , 70, 
#nullable restore
#line 31 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                           _retailer.Description

#line default
#line hidden
#nullable disable
                        , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _retailer.Description = __value, _retailer.Description)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(73);
                    __builder3.AddAttribute(74, "Class", "d-flex justify-end py-2 px-1");
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 36 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                 if (_isEditing)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudButton>(76);
                        __builder4.AddAttribute(77, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 38 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                               Color.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(79, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                     Delete

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(81, "Delete");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 39 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudButton>(82);
                        __builder4.AddAttribute(83, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 41 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 41 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                           Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                     Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(86, "Class", "ml-4");
                        __builder4.AddAttribute(87, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                                    IsProcessing

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(89, "Cancel");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudButton>(91);
                        __builder4.AddAttribute(92, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 42 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 42 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                   Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(94, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 42 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(95, "Class", "ml-2");
                        __builder4.AddAttribute(96, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
                                                                                                                                IsProcessing

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(98, "Save");
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
#nullable restore
#line 47 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\swarchuck\source\repos\EasyCarpet\EasyCarpet\EasyCarpet.Web\Features\Retailers\Shared\RetailerForm.razor"
       

    private ServerSideValidator _serverSideValidator;
    private bool _isEditing = false;
    private string _transactionMode = "Adding a Retailer";
    private RetailerFormModel _retailer = new RetailerFormModel();

    [Parameter] public RetailerFormModel Retailer { get; set; }
    [Parameter] public bool IsProcessing { get; set; } = false;
    [Parameter] public CommandResponse CommandResponse { get; set; }
    [Parameter] public Action OnCancel { get; set; }
    [Parameter] public Func<Guid, Task> OnDelete { get; set; }
    [Parameter] public Func<RetailerFormModel, Task> OnSubmit { get; set; }

    private async Task HandleSubmitAsync() => await OnSubmit(_retailer);
    private void Cancel() => OnCancel();
    private void Delete() => OnDelete(_retailer.Id);

    protected override void OnParametersSet()
    {
        if (Retailer != null)
        {
            _retailer.Id = Retailer.Id;
            _retailer.CompanyName = Retailer.CompanyName;
            _retailer.Address = Retailer.Address;
            _retailer.City = Retailer.City;
            _retailer.State = Retailer.State;
            _retailer.Description = Retailer.Description;
            _retailer.PhoneNumber = Retailer.PhoneNumber;

            _isEditing = true;
            _transactionMode = "Editing a Retailer";
        }


        if (CommandResponse != null && !CommandResponse.IsSuccessful)
        {
            _serverSideValidator.DisplayErrors(CommandResponse.Errors);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.EasyCarpet.Web.Features.Retailers.Shared.RetailerForm
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
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
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
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
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
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
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
        public static void CreateMudTextField_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
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
