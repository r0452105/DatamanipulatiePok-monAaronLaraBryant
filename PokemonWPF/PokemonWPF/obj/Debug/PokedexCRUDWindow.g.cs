﻿#pragma checksum "..\..\PokedexCRUDWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B9702D6E368C549222C158D606B3D9200E13D941865900FBE5EA1DF07225887"
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
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PokemonWPF;
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


namespace PokemonWPF {
    
    
    /// <summary>
    /// PokedexCRUDWindow
    /// </summary>
    public partial class PokedexCRUDWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPokeNumber;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridPokedexEntries;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNaam;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbType1;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbType2;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChange;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReplace;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\PokedexCRUDWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/PokemonWPF;component/pokedexcrudwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PokedexCRUDWindow.xaml"
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
            
            #line 16 "..\..\PokedexCRUDWindow.xaml"
            ((PokemonWPF.PokedexCRUDWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPokeNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PokedexCRUDWindow.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datagridPokedexEntries = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\PokedexCRUDWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cmbType1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.cmbType2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\PokedexCRUDWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnChange = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.btnReplace = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\PokedexCRUDWindow.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

