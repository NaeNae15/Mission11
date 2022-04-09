#pragma checksum "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0d52db6f2e09d1304738478feb713b010ddefd3"
// <auto-generated/>
#pragma warning disable 1591
namespace BookstoreProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using BookstoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class OrdersTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered table-dark");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "colspan", "5");
            __builder.AddAttribute(8, "class", "text-center");
#nullable restore
#line 4 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
__builder.AddContent(9, TableTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 7 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
         if (Orders?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
             foreach (Purchase p in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 12 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
__builder.AddContent(18, p.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 13 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
__builder.AddContent(21, p.Zip);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.AddMarkupContent(23, "<th>Book</th>\n                    ");
            __builder.AddMarkupContent(24, "<th>Quantity</th>\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\n                        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
                                            e => OrderSelected.InvokeAsync(p.PurchaseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\n                            ");
#nullable restore
#line 19 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
__builder.AddContent(31, ButtonLabel);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 23 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
                 foreach (CartLineItem line in p.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\n                        <td colspan=\"2\"></td>\n                        ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 27 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
__builder.AddContent(40, line.Book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                        ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 28 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
__builder.AddContent(43, line.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        <td></td>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 31 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.AddMarkupContent(47, "<tr><td colspan=\"5\" class=\"text-center\">No Orders</td></tr>\n");
#nullable restore
#line 37 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/janae/Desktop/BookstoreProject-Mission_9/Pages/Admin/OrdersTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";
    [Parameter]
    public IEnumerable<Purchase> Orders { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";
    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
