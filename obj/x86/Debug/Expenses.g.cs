﻿#pragma checksum "C:\Users\kakas\source\repos\PoePartThreeFinal\Expenses.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED34E587E7EB5224041D155FE06421AFD97C40BFA7DAA9A794F3999BB3CA6209"
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
    partial class Expenses : 
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
            case 2: // Expenses.xaml line 14
                {
                    this._img_bg = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 3: // Expenses.xaml line 28
                {
                    this.tbMonthlyTax = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Expenses.xaml line 34
                {
                    this.tbGroceries = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Expenses.xaml line 40
                {
                    this.tbWaterLights = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Expenses.xaml line 46
                {
                    this.tbTravel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Expenses.xaml line 52
                {
                    this.tbPhone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Expenses.xaml line 58
                {
                    this.tbOther = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Expenses.xaml line 65
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

