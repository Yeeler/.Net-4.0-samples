﻿#pragma checksum "..\..\..\ServiceControlWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "61B3D81A1D7BCDDAD4309D9C3221E575"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Wrox.ProCSharp.WinServices {
    
    
    /// <summary>
    /// ServiceControlWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ServiceControlWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textDisplayName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textStatus;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textType;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStart;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStop;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPause;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonContinue;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRefresh;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExit;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ServiceControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxServices;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ServiceControl;component/servicecontrolwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ServiceControlWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.textDisplayName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.textStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.textType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.textName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.buttonStart = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\ServiceControlWindow.xaml"
            this.buttonStart.Click += new System.Windows.RoutedEventHandler(this.OnServiceCommand);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonStop = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\ServiceControlWindow.xaml"
            this.buttonStop.Click += new System.Windows.RoutedEventHandler(this.OnServiceCommand);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonPause = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ServiceControlWindow.xaml"
            this.buttonPause.Click += new System.Windows.RoutedEventHandler(this.OnServiceCommand);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonContinue = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\ServiceControlWindow.xaml"
            this.buttonContinue.Click += new System.Windows.RoutedEventHandler(this.OnServiceCommand);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ServiceControlWindow.xaml"
            this.buttonRefresh.Click += new System.Windows.RoutedEventHandler(this.OnRefresh);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\ServiceControlWindow.xaml"
            this.buttonExit.Click += new System.Windows.RoutedEventHandler(this.OnExit);
            
            #line default
            #line hidden
            return;
            case 12:
            this.listBoxServices = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}