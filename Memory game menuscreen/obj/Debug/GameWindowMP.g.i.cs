﻿#pragma checksum "..\..\GameWindowMP.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F3E8B654880BB1DC3B51D7A52456DD90A98A0BD308C17D49BC4DD298BC16B484"
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
    /// GameWindowMP
    /// </summary>
    public partial class GameWindowMP : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\GameWindowMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Naam1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GameWindowMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Naam2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GameWindowMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Score1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\GameWindowMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Score2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GameWindowMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGridMP;
        
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
            System.Uri resourceLocater = new System.Uri("/Memory game menuscreen;component/gamewindowmp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameWindowMP.xaml"
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
            this.Naam1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Naam2 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Score1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Score2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.MainGridMP = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            
            #line 40 "..\..\GameWindowMP.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\GameWindowMP.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackMP);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

