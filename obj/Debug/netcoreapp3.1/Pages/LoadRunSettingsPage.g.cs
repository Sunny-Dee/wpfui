﻿#pragma checksum "..\..\..\..\Pages\LoadRunSettingsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FCD33766E937E86FFA44DDD11935C8870AE37D10"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dart;
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
using XamlAnimatedGif;


namespace Dart {
    
    
    /// <summary>
    /// LoadRunSettingsPage
    /// </summary>
    public partial class LoadRunSettingsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel loadRunSettingsStackPanel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label loadRunSettingsPageTitle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label loadRunSettingsPageSubtitle;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid chooseSourcePanel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadFromFileButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadFromBuildButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadFromVSTSDrop;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button advancedSettingsButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image workingOnIt;
        
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
            System.Uri resourceLocater = new System.Uri("/Dart;component/pages/loadrunsettingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
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
            this.loadRunSettingsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.loadRunSettingsPageTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.loadRunSettingsPageSubtitle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.chooseSourcePanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.loadFromFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
            this.loadFromFileButton.Click += new System.Windows.RoutedEventHandler(this.LoadFromFileHandler);
            
            #line default
            #line hidden
            return;
            case 6:
            this.loadFromBuildButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
            this.loadFromBuildButton.Click += new System.Windows.RoutedEventHandler(this.LoadFromBuildHandler);
            
            #line default
            #line hidden
            return;
            case 7:
            this.loadFromVSTSDrop = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
            this.loadFromVSTSDrop.Click += new System.Windows.RoutedEventHandler(this.LoadFromVSTSDrop);
            
            #line default
            #line hidden
            return;
            case 8:
            this.advancedSettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Pages\LoadRunSettingsPage.xaml"
            this.advancedSettingsButton.Click += new System.Windows.RoutedEventHandler(this.AdvancedRunSettingsHandler);
            
            #line default
            #line hidden
            return;
            case 9:
            this.workingOnIt = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

