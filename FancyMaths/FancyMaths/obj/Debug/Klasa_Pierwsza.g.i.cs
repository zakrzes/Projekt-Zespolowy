﻿#pragma checksum "..\..\Klasa_Pierwsza.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FCE720CD31ED478AD0CA7E39D5A7E1CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
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


namespace FancyMaths {
    
    
    /// <summary>
    /// Klasa_Pierwsza
    /// </summary>
    public partial class Klasa_Pierwsza : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Klasa_Pierwsza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Klasa_Pierwsza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Klasa_Pierwsza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pierwsza_dodawanie;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Klasa_Pierwsza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pierwsza_odejmowanie;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Klasa_Pierwsza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pierwsza_dod_i_odej;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Klasa_Pierwsza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pierwsza_zaleznosci;
        
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
            System.Uri resourceLocater = new System.Uri("/FancyMaths;component/klasa_pierwsza.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Klasa_Pierwsza.xaml"
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
            this.Grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Klasa_Pierwsza.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Pierwsza_dodawanie = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Klasa_Pierwsza.xaml"
            this.Pierwsza_dodawanie.Click += new System.Windows.RoutedEventHandler(this.Pierwsza_dodawanie_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Pierwsza_odejmowanie = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Klasa_Pierwsza.xaml"
            this.Pierwsza_odejmowanie.Click += new System.Windows.RoutedEventHandler(this.Pierwsza_odejmowanie_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pierwsza_dod_i_odej = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Klasa_Pierwsza.xaml"
            this.Pierwsza_dod_i_odej.Click += new System.Windows.RoutedEventHandler(this.Pierwsza_dod_i_odej_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Pierwsza_zaleznosci = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Klasa_Pierwsza.xaml"
            this.Pierwsza_zaleznosci.Click += new System.Windows.RoutedEventHandler(this.Pierwsza_zaleznosci_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

