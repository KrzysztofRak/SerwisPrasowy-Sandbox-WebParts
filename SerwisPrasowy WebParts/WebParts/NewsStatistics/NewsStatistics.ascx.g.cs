﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerwisPrasowy_WebParts.WebParts.StatystykiNewsow {
    using System.Web;
    using System.Text.RegularExpressions;
    using Microsoft.SharePoint.WebPartPages;
    using Microsoft.SharePoint.WebControls;
    using System.Web.Security;
    using Microsoft.SharePoint.Utilities;
    using System.Web.UI;
    using System;
    using System.Web.UI.WebControls;
    using System.Collections.Specialized;
    using Microsoft.SharePoint;
    using System.Collections;
    using System.Web.Profile;
    using System.Text;
    using System.Web.Caching;
    using System.Configuration;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.SessionState;
    using System.Web.UI.HtmlControls;
    using System.CodeDom.Compiler;
    
    
    public partial class StatystykiNewsow {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label Label1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelAddedTodayNum;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelAddedTodayNumVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelAveragePerDayNum;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelAveragePerDayNumVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelLeastNewsInCat;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelLeastNewsInCatVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelNumInLastWeek;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelNumInLastWeekVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelMostNewsInCat;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelMostNewsInCatVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelTotalNum;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelTotalNumVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelMostPopularNews;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.HyperLink HyperLinkMostPopularNewsVal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(StatystykiNewsow target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabel1() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.Label1 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Label1";
            @__ctrl.Font.Bold = true;
            @__ctrl.Font.Size = System.Web.UI.WebControls.FontUnit.Medium;
            @__ctrl.ForeColor = ((System.Drawing.Color)(System.Drawing.Color.FromArgb(0, 102, 255)));
            @__ctrl.Text = "Statystyki naszych newsów";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelAddedTodayNum() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelAddedTodayNum = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelAddedTodayNum";
            @__ctrl.Text = "Dodanych dzisiaj: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelAddedTodayNumVal() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelAddedTodayNumVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelAddedTodayNumVal";
            @__ctrl.Text = "Num";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelAveragePerDayNum() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelAveragePerDayNum = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelAveragePerDayNum";
            @__ctrl.Text = "Średnia ilość newsów na dzień: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelAveragePerDayNumVal() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelAveragePerDayNumVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelAveragePerDayNumVal";
            @__ctrl.Text = "Num";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelLeastNewsInCat() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelLeastNewsInCat = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelLeastNewsInCat";
            @__ctrl.Text = "Najmniej newsów w kategorii: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelLeastNewsInCatVal() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelLeastNewsInCatVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelLeastNewsInCatVal";
            @__ctrl.Text = "Num";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelNumInLastWeek() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelNumInLastWeek = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelNumInLastWeek";
            @__ctrl.Text = "Dodanych w ciągu ostatniego tygodnia: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelNumInLastWeekVal() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelNumInLastWeekVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelNumInLastWeekVal";
            @__ctrl.Text = "Num";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelMostNewsInCat() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelMostNewsInCat = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelMostNewsInCat";
            @__ctrl.Text = "Najwięcej newsów w kategorii: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelMostNewsInCatVal() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelMostNewsInCatVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelMostNewsInCatVal";
            @__ctrl.Text = "Num";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelTotalNum() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelTotalNum = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelTotalNum";
            @__ctrl.Text = "Ilość wszystkich newsów: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelTotalNumVal() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelTotalNumVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelTotalNumVal";
            @__ctrl.Text = "Num";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelMostPopularNews() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelMostPopularNews = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelMostPopularNews";
            @__ctrl.Text = "Najpopularniejszy news: ";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.HyperLink @__BuildControlHyperLinkMostPopularNewsVal() {
            global::System.Web.UI.WebControls.HyperLink @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HyperLink();
            this.HyperLinkMostPopularNewsVal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "HyperLinkMostPopularNewsVal";
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("NewsTitle"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::SerwisPrasowy_WebParts.WebParts.StatystykiNewsow.StatystykiNewsow @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
<style type=""text/css"">


    .auto-style1 {
        height: 23px;
    }
    .auto-style4 {
        height: 23px;
        width: 330px;
    }
    .auto-style3 {
        width: 381px;
    }
    .auto-style5 {
        height: 23px;
        width: 381px;
    }
    </style>

<table style=""width: 100%;"">
    <tr>
        <td class=""auto-style1"" colspan=""5"">
            "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControlLabel1();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"auto-style1\" colspan=\"5\"" +
                        "></td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"auto-style5\">\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl2;
            @__ctrl2 = this.@__BuildControlLabelAddedTodayNum();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl3;
            @__ctrl3 = this.@__BuildControlLabelAddedTodayNumVal();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n        <td class=\"auto-style4\">&nbsp;</td>\r\n        <td class=\"" +
                        "auto-style1\"></td>\r\n        <td class=\"auto-style1\"></td>\r\n        <td class=\"au" +
                        "to-style1\"></td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"auto-style5\">\r\n       " +
                        "     "));
            global::System.Web.UI.WebControls.Label @__ctrl4;
            @__ctrl4 = this.@__BuildControlLabelAveragePerDayNum();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl5;
            @__ctrl5 = this.@__BuildControlLabelAveragePerDayNumVal();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n        <td class=\"auto-style1\" colspan=\"4\">\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl6;
            @__ctrl6 = this.@__BuildControlLabelLeastNewsInCat();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl7;
            @__ctrl7 = this.@__BuildControlLabelLeastNewsInCatVal();
            @__parser.AddParsedSubObject(@__ctrl7);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"auto-style5\">\r\n         " +
                        "   "));
            global::System.Web.UI.WebControls.Label @__ctrl8;
            @__ctrl8 = this.@__BuildControlLabelNumInLastWeek();
            @__parser.AddParsedSubObject(@__ctrl8);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl9;
            @__ctrl9 = this.@__BuildControlLabelNumInLastWeekVal();
            @__parser.AddParsedSubObject(@__ctrl9);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n        <td class=\"auto-style1\" colspan=\"4\">\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl10;
            @__ctrl10 = this.@__BuildControlLabelMostNewsInCat();
            @__parser.AddParsedSubObject(@__ctrl10);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl11;
            @__ctrl11 = this.@__BuildControlLabelMostNewsInCatVal();
            @__parser.AddParsedSubObject(@__ctrl11);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"auto-style3\">\r\n         " +
                        "   "));
            global::System.Web.UI.WebControls.Label @__ctrl12;
            @__ctrl12 = this.@__BuildControlLabelTotalNum();
            @__parser.AddParsedSubObject(@__ctrl12);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl13;
            @__ctrl13 = this.@__BuildControlLabelTotalNumVal();
            @__parser.AddParsedSubObject(@__ctrl13);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n        <td colspan=\"4\">\r\n            "));
            global::System.Web.UI.WebControls.Label @__ctrl14;
            @__ctrl14 = this.@__BuildControlLabelMostPopularNews();
            @__parser.AddParsedSubObject(@__ctrl14);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.HyperLink @__ctrl15;
            @__ctrl15 = this.@__BuildControlHyperLinkMostPopularNewsVal();
            @__parser.AddParsedSubObject(@__ctrl15);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n\r\n"));
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}