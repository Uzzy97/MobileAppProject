﻿#pragma checksum "C:\Users\Usman\Documents\GitHub\MobileAppProject\EducationCenter\Page2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "157BD96B729B97FD309CB21111780F8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationCenter
{
    partial class Page2 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.myPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 2:
                {
                    this.gridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 3:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\Page2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Tapped += this.button_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\Page2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Tapped += this.button_Tapped_1;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

