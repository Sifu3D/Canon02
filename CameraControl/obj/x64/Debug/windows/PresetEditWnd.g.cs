﻿#pragma checksum "..\..\..\..\windows\PresetEditWnd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "729228062D00EC9F9AEAA09FBCCA9750A79C3D13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CameraControl.Core;
using CameraControl.Core.Translation;
using CameraControl.windows;
using MahApps.Metro.Controls;
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


namespace CameraControl.windows {
    
    
    /// <summary>
    /// PresetEditWnd
    /// </summary>
    public partial class PresetEditWnd : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\windows\PresetEditWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox btn_stay_on_top;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\windows\PresetEditWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lst_preset;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\windows\PresetEditWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lst_properties;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\windows\PresetEditWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_del_preset;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\windows\PresetEditWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_del_prop;
        
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
            System.Uri resourceLocater = new System.Uri("/CameraControl;component/windows/preseteditwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\windows\PresetEditWnd.xaml"
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
            
            #line 7 "..\..\..\..\windows\PresetEditWnd.xaml"
            ((CameraControl.windows.PresetEditWnd)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_stay_on_top = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.lst_preset = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.lst_properties = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.btn_del_preset = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\windows\PresetEditWnd.xaml"
            this.btn_del_preset.Click += new System.Windows.RoutedEventHandler(this.btn_del_preset_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_del_prop = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\windows\PresetEditWnd.xaml"
            this.btn_del_prop.Click += new System.Windows.RoutedEventHandler(this.btn_del_prop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
