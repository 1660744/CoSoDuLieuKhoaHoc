#pragma checksum "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb496ba23086eeaf337bafbc6f75cdc9277e1e74"
// <auto-generated/>
#pragma warning disable 1591
namespace CoSoDuLieuKhoaHoc.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "nav flex-column");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "class", "nav-item px-3 py-2");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "class", "nav-link ");
            __builder.AddAttribute(10, "href", "");
            __builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Shared\NavMenu.razor"
                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Trang Chủ\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item px-3 py-2");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "href", "NhaKhoaHoc");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Nhà Khoa Học\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3 py-2");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "detaikhoahoc");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Đề Tài Khoa Học\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3 py-2 py-2");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "baibaokhoahoc");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Bài Báo Khoa Học\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3 py-2");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "sachvagiaotrinh");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Sách Và Giáo Trình\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "nav-item px-3 py-2");
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "class", "nav-link");
            __builder.AddAttribute(61, "href", "phatminhgiaiphap");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Phát Minh Giải Pháp\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "li");
            __builder.AddAttribute(67, "class", "nav-item px-3 py-2");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(69);
            __builder.AddAttribute(70, "class", "nav-link");
            __builder.AddAttribute(71, "href", "thongke");
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Thống Kê\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
