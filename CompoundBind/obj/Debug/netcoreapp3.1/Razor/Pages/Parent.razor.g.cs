#pragma checksum "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/Parent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e33b30ab481d5054af8c54d231abfdded5e0387"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Parent")]
    public partial class Parent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Parent Component</h3>\n");
            __builder.OpenComponent<CompoundBind.Pages.Child>(1);
            __builder.AddAttribute(2, "MyPhrase", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/Parent.razor"
                       wee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "MyPhraseChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => wee = __value, wee))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/Parent.razor"
       
    public string wee = "Hello how are you";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
