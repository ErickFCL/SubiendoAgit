#pragma checksum "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0727817ecf0ff9019c0d46a3055f37d15ff3137d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\source\repos\Practicando\Practicando\Views\_ViewImports.cshtml"
using Practicando;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\Practicando\Practicando\Views\_ViewImports.cshtml"
using Practicando.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0727817ecf0ff9019c0d46a3055f37d15ff3137d", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a829d161a19dd66ccb5bd78778fea7c76315cade", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
  
    var accounts = ((List<Account>)Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cuentas de (");
#nullable restore
#line 5 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
           Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h1>

<a href=""/account/create"">Crear Cuenta</a>

<table class=""table"">
    <thead>
        <tr>
            <th>Imagen</th>
            <th>Tipo</th>
            <th>Nombre</th>
            <th>Divisa</th>
            <th>Saldo</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 22 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
         foreach (var item in accounts)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 528, "\"", 549, 1);
#nullable restore
#line 27 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
WriteAttributeValue("", 534, item.ImagePath, 534, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" alt=\"Alternate text\"/>\r\n                </td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
               Write(item.Type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
               Write(item.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" S/.</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 849, 2);
            WriteAttributeValue("", 824, "/Account/edit?id=", 824, 17, true);
#nullable restore
#line 34 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
WriteAttributeValue("", 841, item.Id, 841, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 887, "\"", 921, 2);
            WriteAttributeValue("", 894, "/Account/delete?id=", 894, 19, true);
#nullable restore
#line 35 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
WriteAttributeValue("", 913, item.Id, 913, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 961, "\"", 1005, 2);
            WriteAttributeValue("", 968, "/Transaction/Index?accountId=", 968, 29, true);
#nullable restore
#line 36 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
WriteAttributeValue("", 997, item.Id, 997, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Transacciones</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\HP\source\repos\Practicando\Practicando\Views\Account\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
