#pragma checksum "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/One1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831c88999f3c173255499e1dd4c263584df2c0bd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/one1")]
    public partial class One1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-5 bg-success");
            __builder.AddMarkupContent(2, "\n    ");
            __Blazor.CompoundBind.Pages.One1.TypeInference.CreateCascadingValue_0(__builder, 3, 4, 
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/One1.razor"
                            MyMessage

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.OpenComponent<CompoundBind.Pages.Two1>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
            }
            );
            __builder.AddMarkupContent(9, "\n  \n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/vimalraveendran/Desktop/blazor/CompoundBind/CompoundBind/Pages/One1.razor"
       

    public string MyMessage = "Hello World!";


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CompoundBind.Pages.One1
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
