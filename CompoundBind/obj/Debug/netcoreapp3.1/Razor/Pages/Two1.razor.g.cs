#pragma checksum "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/Two1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9ff58d356531baedae79fdce19b9a9b30a5f78c"
// <auto-generated/>
#pragma warning disable 1591
namespace CompoundBind.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using CompoundBind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/_Imports.razor"
using CompoundBind.Shared;

#line default
#line hidden
#nullable disable
    public partial class Two1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-5 bg-secondary");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "h3");
            __builder.AddAttribute(4, "class", "text-white");
            __builder.AddContent(5, 
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/Two1.razor"
                            MyMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenComponent<CompoundBind.Pages.Three1>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n \n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/Two1.razor"
       
    [CascadingParameter]
    public string MyMessage { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
