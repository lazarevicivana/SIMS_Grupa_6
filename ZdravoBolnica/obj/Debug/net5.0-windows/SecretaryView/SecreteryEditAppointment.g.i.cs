﻿#pragma checksum "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB5485C4E304D6C9AC88ED10E260A8EB4FE8C163"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS.SecretaryView;
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


namespace SIMS.SecretaryView {
    
    
    /// <summary>
    /// SecreteryEditAppointment
    /// </summary>
    public partial class SecreteryEditAppointment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Time;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Duration;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoomBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatientBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DoctorBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SIMS;V1.0.0.0;component/secretaryview/secreteryeditappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.Time = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Duration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RoomBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.PatientBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.DoctorBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 23 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditApp_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 24 "..\..\..\..\SecretaryView\SecreteryEditAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

