﻿#pragma checksum "..\..\..\..\Pages\ProductsInShopsAddPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E3247F4CCCA2962848816E8F6BA5331CABE8790B"
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


namespace FoodShop.App.Pages {
    
    
    /// <summary>
    /// ProductsInShopsAddPage
    /// </summary>
    public partial class ProductsInShopsAddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productComboBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox shopComboBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox unitComboBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FoodShop.App;component/pages/productsinshopsaddpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
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
            
            #line 10 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
            ((FoodShop.App.Pages.ProductsInShopsAddPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.productComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.shopComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.amountTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
            this.amountTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.amountTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
            this.amountTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.amountTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.unitComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Pages\ProductsInShopsAddPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

