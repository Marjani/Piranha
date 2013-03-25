﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Settings
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Settings/Access.cshtml")]
    public partial class Access : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.SettingModels.AccessEditModel>
    {
        public Access()
        {
        }
        public override void Execute()
        {
DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 3 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 7 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 8 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
            
            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
             if (!Model.Access.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 323), Tuple.Create("\"", 387)
            
            #line 9 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
, Tuple.Create(Tuple.Create("", 330), Tuple.Create<System.Object, System.Int32>(Url.Action("deleteaccess", new { id = Model.Access.Id })
            
            #line default
            #line hidden
, 330), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 9 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                                              Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 10 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 487), Tuple.Create("\"", 519)
            
            #line 11 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
, Tuple.Create(Tuple.Create("", 494), Tuple.Create<System.Object, System.Int32>(Url.Action("accesslist")
            
            #line default
            #line hidden
, 494), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 11 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                            Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 600), Tuple.Create("\"", 658)
            
            #line 12 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
, Tuple.Create(Tuple.Create("", 607), Tuple.Create<System.Object, System.Int32>(Url.Action("access", new { id = Model.Access.Id })
            
            #line default
            #line hidden
, 607), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 12 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                                         Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 18 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
   Html.BeginForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
Write(Html.HiddenFor(m => m.Access.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
Write(Html.HiddenFor(m => m.Access.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
Write(Html.HiddenFor(m => m.Access.IsLocked));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
Write(Html.HiddenFor(m => m.Access.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 23 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
Write(Html.HiddenFor(m => m.Access.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 26 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
               Write(Html.LabelFor(m => m.Access.Function));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                         if (!Model.Access.IsLocked) {
                            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                       Write(Html.TextBoxFor(m => m.Access.Function));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                    
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                       Write(Html.TextBoxFor(m => m.Access.Function, new { disabled = "disabled" }));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                                                   
                            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                       Write(Html.HiddenFor(m => m.Access.Function));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                   
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

WriteLiteral("                    ");

            
            #line 39 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
               Write(Html.ValidationMessageFor(m => m.Access.Function));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
               Write(Html.LabelFor(m => m.Access.GroupId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                   Write(Html.DropDownListFor(m => m.Access.GroupId, Model.Groups));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
               Write(Html.ValidationMessageFor(m => m.Access.GroupId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 48 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
               Write(Html.LabelFor(m => m.Access.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                         if (!Model.Access.IsLocked) {
                            
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                       Write(Html.TextAreaFor(m => m.Access.Description, 
                                new { @rows = 3, @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 52 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                                                    
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                       Write(Html.TextAreaFor(m => m.Access.Description, 
                                new { @rows = 3, @disabled = "disabled", @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                                                                            
                            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                       Write(Html.HiddenFor(m => m.Access.Description));

            
            #line default
            #line hidden
            
            #line 56 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                                                                      
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </li>\r\n            </ul>\r\n        </d" +
"iv>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 66 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                          Write(Piranha.Resources.Settings.AccessMembers);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n");

            
            #line 68 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
            
            
            #line default
            #line hidden
            
            #line 68 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
             if (!Model.Access.IsNew) {

            
            #line default
            #line hidden
WriteLiteral("            <ul>\r\n                <li>Todo</li>\r\n            </ul>\r\n");

            
            #line 72 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
            } else {

            
            #line default
            #line hidden
WriteLiteral("                <p><em>");

            
            #line 73 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
                  Write(Piranha.Resources.Settings.AccessMembersNew);

            
            #line default
            #line hidden
WriteLiteral("</em></p>\r\n");

            
            #line 74 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 78 "..\..\Areas\Manager\Views\Settings\Access.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591