﻿#pragma checksum "..\..\Opties.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4FDD62D28D19A7CC5DBC3411680D063AAA28FF92F78AD2949E2E09A2B4439825"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Memory_game_menuscreen;
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


namespace Memory_game_menuscreen {
    
    
    /// <summary>
    /// Opties
    /// </summary>
    public partial class Opties : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\Opties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Naam1;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Opties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Speleraantal1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Opties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Speleraantal2;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Opties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Terugbutton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Opties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Speelveld1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Opties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Speelveld2;
        
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
            System.Uri resourceLocater = new System.Uri("/Memory game menuscreen;component/opties.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Opties.xaml"
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
            this.Naam1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Speleraantal1 = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Speleraantal2 = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Terugbutton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Opties.xaml"
            this.Terugbutton.Click += new System.Windows.RoutedEventHandler(this.BackToMenu);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Speelveld1 = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Speelveld2 = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

