﻿#pragma checksum "C:\Users\kakas\source\repos\PoePartThreeFinal\Vehicle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E388E5C3405AE46682E33CE11E7195740519A1335DA29E227B8CDD934D1CF93"
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
    partial class Vehicle : 
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
            case 2: // Vehicle.xaml line 14
                {
                    this._img_bg = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 3: // Vehicle.xaml line 27
                {
                    this.tbModel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Vehicle.xaml line 35
                {
                    this.tbPrice = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Vehicle.xaml line 42
                {
                    this.tbDeposit = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Vehicle.xaml line 49
                {
                    this.tbInterest = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Vehicle.xaml line 57
                {
                    this.tbInsurance = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Vehicle.xaml line 65
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.btnSubmit_Click;
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

