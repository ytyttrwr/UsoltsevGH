﻿#pragma checksum "..\..\AddOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9113EB1168327ACE5D6C8398825291626EC4CE4C60D7E095DA7A72B890F38D2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OxtaPark;
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


namespace OxtaPark {
    
    
    /// <summary>
    /// AddOrder
    /// </summary>
    public partial class AddOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchtb;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Datepick;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgClient;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clientadd;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Timetb;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox checkclient;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodeOrdertb;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addservice;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbService1;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbService2;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbService3;
        
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
            System.Uri resourceLocater = new System.Uri("/OxtaPark;component/addorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddOrder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.searchtb = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AddOrder.xaml"
            this.searchtb.SelectionChanged += new System.Windows.RoutedEventHandler(this.searchtb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddOrder.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AddOrder.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Datepick = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.DgClient = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\AddOrder.xaml"
            this.DgClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.clientadd = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\AddOrder.xaml"
            this.clientadd.Click += new System.Windows.RoutedEventHandler(this.clientadd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Timetb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.checkclient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.CodeOrdertb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.addservice = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\AddOrder.xaml"
            this.addservice.Click += new System.Windows.RoutedEventHandler(this.addservice_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CbService1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.CbService2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.CbService3 = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

