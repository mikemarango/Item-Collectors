﻿

#pragma checksum "C:\Users\Deivi\Documents\GitHub\WindowsPhone_development\Item Collectors\Item Collectors\GridViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "056256DF80B7418F41F1608B5308451D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Item_Containers
{
    partial class GridViewPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\GridViewPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 65 "..\..\GridViewPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.listView_Holding;
                 #line default
                 #line hidden
                #line 66 "..\..\GridViewPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.listView_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


