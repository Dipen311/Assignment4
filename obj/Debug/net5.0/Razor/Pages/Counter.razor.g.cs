#pragma checksum "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d9498e168ed8a2a0f53d81a87b6f68dafbd216"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using MovieBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\_Imports.razor"
using MovieBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "strong");
            __builder.AddContent(3, 
#nullable restore
#line 4 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
            name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Current count: ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, "Current Incrementer: ");
            __builder.AddContent(16, 
#nullable restore
#line 9 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
                         IncrementAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
                                          IncrementIncreaser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Increment Incrementer");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
                                          DecreaseIncreser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Decrease Incrrementer");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "h4");
            __builder.AddContent(29, "High Score: ");
            __builder.AddContent(30, 
#nullable restore
#line 13 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
                 highscore

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "F:\INTERNET APPLICATION AND WEB DEVELOPMENT\SEM 2\ASP\assignment 3\MovieBlazorApp\Pages\Counter.razor"
       
    private int currentCount = 1;
     
    [Parameter] 
    public string name {get;set;}
    private int highscore = 1;
    [Parameter]
    public int IncrementAmount { get; set;} = 1;
    private void IncrementCount()
    {
        currentCount += IncrementAmount;
        if(highscore <= currentCount){
            highscore = currentCount;
        }
    }
    private void IncrementIncreaser(){
        if(IncrementAmount < 20){
            IncrementAmount++;
        }
        
    }
    private void DecreaseIncreser(){
        if(IncrementAmount > 1){
            IncrementAmount--;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
