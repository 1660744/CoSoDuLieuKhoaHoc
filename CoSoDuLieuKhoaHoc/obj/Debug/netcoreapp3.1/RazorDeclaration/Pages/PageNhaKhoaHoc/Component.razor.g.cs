#pragma checksum "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c9af5bf880bd1141cc20a0767496934e80b6a3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CoSoDuLieuKhoaHoc.Pages.PageNhaKhoaHoc
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor"
using CoSoDuLieuKhoaHoc.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor"
using CoSoDuLieuKhoaHoc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor"
using CoSoDuLieuKhoaHoc.DataServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nkh")]
    public partial class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 155 "C:\Users\Thien\Desktop\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\Component.razor"
           

        DataNhaKhoaHocServices dtnkh = new DataNhaKhoaHocServices();
        List<NhaKhoaHocHomeViewModel> lsNKHHome = new List<NhaKhoaHocHomeViewModel>();
        int soluongnhakhoahoc = 0;

        protected override async Task OnInitializedAsync()
        {
            lsNKHHome = dtnkh.lsnkhHome();
            soluongnhakhoahoc = dtnkh.SLuongNKH();
        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private QLKhoaHocContext Dbcontext { get; set; }
    }
}
#pragma warning restore 1591
