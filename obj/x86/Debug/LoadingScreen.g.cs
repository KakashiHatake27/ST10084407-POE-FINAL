﻿#pragma checksum "C:\Users\kakas\source\repos\PoePartThreeFinal\LoadingScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "435BAB95123AFD2FDA837BDDC7241C3539F3E0DAE9936F05176DDAE669111B07"
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
    partial class LoadingScreen : 
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
            case 2: // LoadingScreen.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).Loaded += this.Grid_Loaded;
                }
                break;
            case 3: // LoadingScreen.xaml line 15
                {
                    this.BG = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // LoadingScreen.xaml line 19
                {
                    this._img_bg = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                    ((global::Windows.UI.Xaml.Media.ImageBrush)this._img_bg).ImageOpened += this._img_bg_ImageOpened;
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

