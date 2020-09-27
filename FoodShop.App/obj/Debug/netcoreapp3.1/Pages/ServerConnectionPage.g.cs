﻿#pragma checksum "..\..\..\..\Pages\ServerConnectionPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54D67F018BE024255A07CD5D4A68425AE2E75D63"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FoodShop.App.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfAnimatedGif;


namespace FoodShop.App.Pages {
    
    
    /// <summary>
    /// ServerConnectionPage
    /// </summary>
    public partial class ServerConnectionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Pages\ServerConnectionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serverNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\ServerConnectionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dbLoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\ServerConnectionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox dbPasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\ServerConnectionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button authButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\ServerConnectionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LoadingAnimation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FoodShop.App;component/pages/serverconnectionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ServerConnectionPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.serverNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\Pages\ServerConnectionPage.xaml"
            this.serverNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.serverNameTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\Pages\ServerConnectionPage.xaml"
            this.serverNameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.serverNameTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dbLoginTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\Pages\ServerConnectionPage.xaml"
            this.dbLoginTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.dbLoginTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\Pages\ServerConnectionPage.xaml"
            this.dbLoginTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.dbLoginTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dbPasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.authButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Pages\ServerConnectionPage.xaml"
            this.authButton.Click += new System.Windows.RoutedEventHandler(this.authButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LoadingAnimation = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

