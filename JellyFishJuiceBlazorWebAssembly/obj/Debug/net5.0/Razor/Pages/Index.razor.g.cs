#pragma checksum "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba924fb5cb948bc0b6c36ed5f76ca22bf0c71d6"
// <auto-generated/>
#pragma warning disable 1591
namespace JellyFishJuiceBlazorWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyFishJuiceBlazorWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\_Imports.razor"
using JellyFishJuiceBlazorWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
using JellyFishJuiceBlazorWebAssembly.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, Jellyfish Juice!!</h1>\r\n\r\nWelcome to your new app.  Let\'s count!\'\r\n\r\n");
            __builder.OpenComponent<JellyFishJuiceBlazorWebAssembly.Pages.Counter>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(3, "<h1>Customer Contact</h1>\r\n");
            __builder.AddMarkupContent(4, "<p>We\'d love to hear from you! We try our best to respond within 24 hours.</p>\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                  Contact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"name\">Name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "firstName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Enter first name");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                                                     Contact.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.Name = __value, Contact.Name))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __Blazor.JellyFishJuiceBlazorWebAssembly.Pages.Index.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 21 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                  () => Contact.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label for=\"email\">Email: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "email");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "placeholder", "Enter email");
                __builder2.AddAttribute(34, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                                                 Contact.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.Email = __value, Contact.Email))));
                __builder2.AddAttribute(36, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __Blazor.JellyFishJuiceBlazorWebAssembly.Pages.Index.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 26 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                  () => Contact.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"email\">Phone: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "phone");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "Enter phone");
                __builder2.AddAttribute(48, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                                                 Contact.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.Phone = __value, Contact.Phone))));
                __builder2.AddAttribute(50, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __Blazor.JellyFishJuiceBlazorWebAssembly.Pages.Index.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 31 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                  () => Contact.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label for=\"message\">Message: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(58);
                __builder2.AddAttribute(59, "id", "message");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", "Enter message");
                __builder2.AddAttribute(62, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                                                       Contact.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Contact.Message = __value, Contact.Message))));
                __builder2.AddAttribute(64, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Contact.Message));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __Blazor.JellyFishJuiceBlazorWebAssembly.Pages.Index.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 36 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                  () => Contact.Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(69, "<button type=\"submit\" class=\"btn btn-info\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\medav\source\repos\JellyStaticWebsite\JellyFishJuiceBlazorWebAssembly\Pages\Index.razor"
                                                  

    public Contact Contact = new Contact();

    IReadOnlyList<IBrowserFile> selectedFiles;

    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles(3);
    }

    private async void HandleValidSubmit()
    {
        Contact.SubmittedTime = DateTime.UtcNow;
        //await ContactService.PostContact(Contact, selectedFiles);
        //NavManager.NavigateTo("contact-confirmation");
    }


    //WeatherForecastController wc = new WeatherForecastController();


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.JellyFishJuiceBlazorWebAssembly.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
