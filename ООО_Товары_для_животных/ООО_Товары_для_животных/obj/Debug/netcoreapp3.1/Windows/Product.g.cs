﻿#pragma checksum "..\..\..\..\Windows\Product.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F5665DDB5FAABE58F37FC38553BD8223A8FB5F90"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using ООО_Товары_для_животных.Windows;


namespace ООО_Товары_для_животных.Windows {
    
    
    /// <summary>
    /// Product
    /// </summary>
    public partial class Product : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtration;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Asc;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Desc;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ProductView;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\Product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ООО_Товары_для_животных;component/windows/product.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Product.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\Windows\Product.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Filtration = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\..\Windows\Product.xaml"
            this.Filtration.DropDownClosed += new System.EventHandler(this.Filtration_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Asc = ((System.Windows.Controls.RadioButton)(target));
            
            #line 28 "..\..\..\..\Windows\Product.xaml"
            this.Asc.Checked += new System.Windows.RoutedEventHandler(this.Asc_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Desc = ((System.Windows.Controls.RadioButton)(target));
            
            #line 29 "..\..\..\..\Windows\Product.xaml"
            this.Desc.Checked += new System.Windows.RoutedEventHandler(this.Desc_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProductView = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Windows\Product.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Windows\Product.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

