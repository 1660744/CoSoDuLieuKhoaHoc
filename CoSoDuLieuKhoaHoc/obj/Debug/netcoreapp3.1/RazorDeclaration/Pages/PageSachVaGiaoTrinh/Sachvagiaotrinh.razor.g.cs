#pragma checksum "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3582e21e9aad6eecc1b487b98d46ac7283b8ee55"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CoSoDuLieuKhoaHoc.Pages.PageSachVaGiaoTrinh
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
#nullable restore
#line 3 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using CoSoDuLieuKhoaHoc.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using CoSoDuLieuKhoaHoc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using CoSoDuLieuKhoaHoc.DataServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sachvagiaotrinh")]
    public partial class Sachvagiaotrinh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
           
        RadzenGrid<SachVaGiaoTrinhViewModel> ordersGrid;
        IList<SachVaGiaoTrinhViewModel> orders;
        List<SachVaGiaoTrinhViewModel> nkhvmd = new List<SachVaGiaoTrinhViewModel>();
        DataSachGiaoTrinhServices dt = new DataSachGiaoTrinhServices();
        protected override async Task OnInitializedAsync()
        {
            nkhvmd = await dt.GetLisSachVaGiaoTrinh();

        }
        void EditRow(SachVaGiaoTrinhViewModel order)
        {
            ordersGrid.EditRow(order);
        }

        void OnUpdateRow(SachVaGiaoTrinhViewModel order)
        {
            Dbcontext.Update<SachVaGiaoTrinhViewModel>(order);
        }

        void SaveRow(SachVaGiaoTrinhViewModel order)
        {
            ordersGrid.UpdateRow(order);
        }

        void CancelEdit(SachVaGiaoTrinhViewModel order)
        {
            ordersGrid.CancelEditRow(order);

            // For production
            var orderEntry = Dbcontext.Entry(order);
            orderEntry.CurrentValues.SetValues(orderEntry.OriginalValues);
            orderEntry.State = EntityState.Unchanged;
        }

        void DeleteRow(SachVaGiaoTrinhViewModel order)
        {
            Dbcontext.Remove<SachVaGiaoTrinhViewModel>(order);

            // For demo purposes only
            orders.Remove(order);

            // For production
            //dbContext.SaveChanges();

            ordersGrid.Reload();
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\Administrator.DESKTOP-MOMBPDQ\Desktop\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
           
        public List<SampleData> GridData { get; set; }

        protected override void OnInitialized()
        {
            GridData = GetData();
        }

        private List<SampleData> GetData()
        {
            return Enumerable.Range(1, 50).Select(x => new SampleData
            {
                Id = x,
                Name = $"name {x}",
                LastName = $"Surname {x}"
            }).ToList();
        }

        public class SampleData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private QLKhoaHocContext Dbcontext { get; set; }
    }
}
#pragma warning restore 1591
