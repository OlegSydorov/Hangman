﻿#pragma checksum "..\..\Page3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39BA30BD68D403A5548CB397D4563A8CF4FB319E5D45FC42FCA39C6AB82C3181"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HaNgMaN;
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


namespace HaNgMaN {
    
    
    /// <summary>
    /// Page3
    /// </summary>
    public partial class Page3 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tBlock;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.DropShadowEffect shadow1;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path back;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.SolidColorBrush colorFillB;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.DropShadowEffect shadowB;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path forward;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.SolidColorBrush colorFill;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.DropShadowEffect shadowF;
        
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
            System.Uri resourceLocater = new System.Uri("/HaNgMaN;component/page3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page3.xaml"
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
            this.tBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.shadow1 = ((System.Windows.Media.Effects.DropShadowEffect)(target));
            return;
            case 3:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\Page3.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.Close_ButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.back = ((System.Windows.Shapes.Path)(target));
            
            #line 104 "..\..\Page3.xaml"
            this.back.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Back_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.colorFillB = ((System.Windows.Media.SolidColorBrush)(target));
            return;
            case 6:
            this.shadowB = ((System.Windows.Media.Effects.DropShadowEffect)(target));
            return;
            case 7:
            this.forward = ((System.Windows.Shapes.Path)(target));
            
            #line 147 "..\..\Page3.xaml"
            this.forward.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Forward_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.colorFill = ((System.Windows.Media.SolidColorBrush)(target));
            return;
            case 9:
            this.shadowF = ((System.Windows.Media.Effects.DropShadowEffect)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
