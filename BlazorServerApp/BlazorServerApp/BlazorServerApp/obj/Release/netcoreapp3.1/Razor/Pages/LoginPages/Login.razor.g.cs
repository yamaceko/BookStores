#pragma checksum "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f7b49122a620e6f591b5dd9b17f547e2a042eb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Pages.LoginPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
using BlazorServerApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CenteredCardLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
                                        ValidateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, "<div>\r\n        <br><br><br><br><br>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(6, "<div>\r\n        <h3 style=\"font-weight:bold; color:purple\">Book Stores Login</h3>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(7, "<div>\r\n        <br>\r\n    </div>\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-12 row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "class", "form-control col-12");
                __builder2.AddAttribute(13, "placeholder", "email address");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
                                                  user.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.EmailAddress = __value, user.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-12 row");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "password");
                __builder2.AddAttribute(23, "class", "form-control col-12");
                __builder2.AddAttribute(24, "placeholder", "password");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
                                                                  user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(29, "<div class=\"col-12 row\">\r\n        <span class=\"col-12\"></span>\r\n        <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Login\">\r\n        <a href=\"/signup\" class=\"col-3\">Sign up</a>\r\n    </div>\r\n    <br>\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-12 row");
                __builder2.AddAttribute(32, "style", "text-align:left; font-weight:bold");
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "span");
                __builder2.AddAttribute(35, "class", "col-12");
                __builder2.AddContent(36, 
#nullable restore
#line 36 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
                              LoginMesssage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorServerApp\BlazorServerApp\Pages\LoginPages\Login.razor"
       

    private User user;
    public string LoginMesssage { get; set; }

    protected override Task OnInitializedAsync()
    {
        user = new User();
        return base.OnInitializedAsync();
    }

    private async Task<bool> ValidateUser()
    {
        //assume that user is valid
        //call an API

        var returnedUser = await userService.LoginAsync(user);

        if (returnedUser.EmailAddress != null)
        {
            await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(returnedUser);
            NavigationManager.NavigateTo("/index");
        }
        else
        {
            LoginMesssage = "Invalid username or password";
        }

        return await Task.FromResult(true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
