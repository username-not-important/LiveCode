﻿#pragma checksum "..\..\..\Pages\DashboardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0134A56D4A680A2D366BAAE431D360B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using livecode.wpf.Listeners;
using livecode.wpf.MVVM.Views;
using livecode.wpf.Pages;


namespace livecode.wpf.Pages {
    
    
    /// <summary>
    /// DashboardPage
    /// </summary>
    public partial class DashboardPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\DashboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorZone _EnabledColorZone;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\DashboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run _EnabledText;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\DashboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton _CheckEnabled;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\DashboardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run _TimerText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/livecode.wpf;component/pages/dashboardpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DashboardPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._EnabledColorZone = ((MaterialDesignThemes.Wpf.ColorZone)(target));
            return;
            case 2:
            this._EnabledText = ((System.Windows.Documents.Run)(target));
            return;
            case 3:
            this._CheckEnabled = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 32 "..\..\..\Pages\DashboardPage.xaml"
            this._CheckEnabled.Checked += new System.Windows.RoutedEventHandler(this._Enabled);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\Pages\DashboardPage.xaml"
            this._CheckEnabled.Unchecked += new System.Windows.RoutedEventHandler(this._Disabled);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 42 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._DefectReportClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 58 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._ExportClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 59 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._ClearClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this._TimerText = ((System.Windows.Documents.Run)(target));
            return;
            case 8:
            
            #line 87 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._PromptFormsClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this._ExitClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 110 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Expander)(target)).Expanded += new System.Windows.RoutedEventHandler(this._TimeExpanderExpanded);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 130 "..\..\..\Pages\DashboardPage.xaml"
            ((System.Windows.Controls.Expander)(target)).Expanded += new System.Windows.RoutedEventHandler(this._SizeExpanderExpanded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
