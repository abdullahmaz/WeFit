#pragma checksum "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cd7d1cf1251e94171d9bba718276427b09a9abbebedc6ff3b5a6bab6a09ea877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bodyweight_summary), @"mvc.1.0.view", @"/Views/Bodyweight/summary.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\_ViewImports.cshtml"
using FitnessTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\_ViewImports.cshtml"
using FitnessTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cd7d1cf1251e94171d9bba718276427b09a9abbebedc6ff3b5a6bab6a09ea877", @"/Views/Bodyweight/summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8076d77d01dee38308418500ab57b55612e7c094a6a259bd5ad1f4afe5dbfc29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bodyweight_summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitnessTracker.ViewModels.BodyweightSummaryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Bodyweight/summary.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bodyweight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRecords", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTodayWeight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-3 mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTarget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.9.4/dist/Chart.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7d1cf1251e94171d9bba718276427b09a9abbebedc6ff3b5a6bab6a09ea8776552", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
  
    ViewData["Title"] = "Bodyweight";

    string FormatWeight(double D)
    {
        //Added this because D = 0 results in "-+0.00kg". Most likely a floating point precision issue.
        if (D == -0)
            D = 0;

        var x = $"{Math.Round(D, 2).ToString("+0.00;-0.00")}kg";
        return x;
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2 class=\"d-inline text-light\">My Bodyweight</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7d1cf1251e94171d9bba718276427b09a9abbebedc6ff3b5a6bab6a09ea8778334", async() => {
                WriteLiteral("+Add Bodyweights");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
 if (Model.MostRecentRecord == null || Model.MostRecentRecord.Date != DateTime.Today)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            <div class=\"alert alert-info mt-3 mb-2\">\r\n                <h5 class=\"ml-3\">Add Today\'s Weight</h5>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7d1cf1251e94171d9bba718276427b09a9abbebedc6ff3b5a6bab6a09ea87710310", async() => {
                WriteLiteral(@"
                    <div class=""input-group form-inline "">
                        <input type=""number"" min=""0"" max=""200"" name=""Weight"" step=""0.1"" class=""form-control mr-1"" required />
                        <input type=""submit"" value=""Save"" class=""btn btn-danger"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row my-3"">
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Most Recent Bodyweight</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 57 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                    Write(Model.MostRecentRecord == null ? "0" : Model.MostRecentRecord.Weight.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("kg\r\n                    </h4>\r\n                    <div class=\"card-text text-center\">\r\n");
#nullable restore
#line 60 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                         if (Model.MostRecentRecord != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                        Write(Model.MostRecentRecord.Date.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class=""col"">
        <div class=""card mb-2"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">This Week's Progress</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 77 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentWeekProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Daily Average (This Week)</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 89 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentWeekAverage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>

    <div class=""col"">
        <div class=""card mb-2"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Current Month's Progress</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 104 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentMonthProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Daily Average (This Month)</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 116 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.CurrentMonthAverage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>

    <div class=""col"">
        <div class=""card mb-2"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">All Time Progress</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 131 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.AllTimeProgress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Weekly Average (All Time)</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 143 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.AllTimeAverage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""row"">
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">

                <h5 class=""card-subtitle d-"">Target Bodyweight <i class=""far fa-edit float-right"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#TargetModal"">Edit</i></h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"" id=""TargetWeight"" data-target=""");
#nullable restore
#line 161 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                                                                                  Write(Model.Target == null ? 0 : Model.Target.TargetWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        ");
#nullable restore
#line 162 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                    Write(Model.Target == null ? "0" : Model.Target.TargetWeight.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("kg\r\n                    </h4>\r\n                    <div class=\"card-text text-center\">\r\n");
#nullable restore
#line 165 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                         if (Model.Target != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                        Write(Model.Target.TargetDate.ToString("d"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                                                                    
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Distance to Target</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 182 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.DistanceToTarget));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Daily Progress Needed</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 196 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.DailyProgressNeeded));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card mheight-100"">
            <div class=""card-header py-3"">
                <h5 class=""card-subtitle"">Weekly Progress Needed</h5>
            </div>
            <div class=""card-body d-flex align-items-center"">
                <div class=""w-100"">
                    <h4 class=""card-title text-center"">
                        ");
#nullable restore
#line 210 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
                   Write(FormatWeight(Model.WeeklyProgressNeeded));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h4>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row mt-3"">

    <div class=""col text-light"">
        <h2 class=""text-center text-light"">This Week</h2>
        <canvas id=""WeekGraph"" style=""max-width:100%;"">
        </canvas>
    </div>
    <div class=""col"">
        <h2 class=""text-center text-light"">This Month</h2>
        <canvas id=""MonthGraph"" style=""max-width:100%;"">
        </canvas>
    </div>
</div>



<div class=""modal fade"" id=""TargetModal"" tabindex=""-1"" aria-labelledby=""TargetModal"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Edit Target</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7d1cf1251e94171d9bba718276427b09a9abbebedc6ff3b5a6bab6a09ea87723896", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"modal-body\">\r\n\r\n\r\n                    <div class=\"form-group\">\r\n                        <label>Weight</label>\r\n                        <input class=\"form-control\" name=\"TargetWeight\" type=\"number\" min=\"1\" max=\"300\"");
                BeginWriteAttribute("value", " value=\"", 9087, "\"", 9172, 1);
#nullable restore
#line 250 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
WriteAttributeValue("", 9095, Model.Target != null ? Model.Target.TargetWeight.ToString() : string.Empty, 9095, 77, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label>Target Date</label>\r\n                        <input class=\"form-control\" name=\"TargetDate\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 9396, "\"", 9491, 1);
#nullable restore
#line 255 "C:\Users\abdullah\Documents\Projects\WeFit\WeFit\Views\Bodyweight\summary.cshtml"
WriteAttributeValue("", 9404, Model.Target != null ? Model.Target.TargetDate.ToString("yyyy-MM-dd") : string.Empty, 9404, 87, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                    <input type=""submit"" class=""btn btn-primary"" value=""Save"">
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitnessTracker.ViewModels.BodyweightSummaryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
