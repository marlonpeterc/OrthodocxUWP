﻿#pragma checksum "C:\Users\marlo\source\repos\Orthodocx\Orthodocx\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DDB06DEA3E83ABDC210E20B48EB9238D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orthodocx
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 23
                {
                    this.nvTopLevelNav = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvTopLevelNav).Loaded += this.nvTopLevelNav_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvTopLevelNav).SelectionChanged += this.nvTopLevelNav_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvTopLevelNav).ItemInvoked += this.nvTopLevelNav_ItemInvoked;
                }
                break;
            case 3: // MainPage.xaml line 30
                {
                    this.Home = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // MainPage.xaml line 36
                {
                    this.Patients = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 42
                {
                    this.Doctors = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 48
                {
                    this.Schedule = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // MainPage.xaml line 54
                {
                    this.Prescriptions = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // MainPage.xaml line 60
                {
                    this.Charts = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 9: // MainPage.xaml line 67
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 10: // MainPage.xaml line 70
                {
                    this.autoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                }
                break;
            case 11: // MainPage.xaml line 16
                {
                    this.appTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

