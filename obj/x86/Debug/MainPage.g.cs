﻿#pragma checksum "C:\Users\kakas\source\repos\PoePartThreeFinal\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E7431BF7FD817DAE4B9571E0EC90D079C41E12EB452C665185A73EE73CC24E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoePartThreeFinal
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).GotFocus += this.Page_GotFocus;
                }
                break;
            case 2: // MainPage.xaml line 12
                {
                    this.NavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).Loaded += this.NavView_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).SelectionChanged += this.NavView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).BackRequested += this.NavView_BackRequested;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).PaneClosed += this.NavView_PaneClosed;
                }
                break;
            case 3: // MainPage.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element3 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element3).Tapped += this.NavigationViewItem_Tapped;
                }
                break;
            case 4: // MainPage.xaml line 68
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

