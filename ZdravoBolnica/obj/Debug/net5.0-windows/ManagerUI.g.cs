﻿#pragma checksum "..\..\..\ManagerUI.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F723B5C1581DCB326252A4E5125C4B48BF85E2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS;
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


namespace SIMS {
    
    
    /// <summary>
    /// ManagerUI
    /// </summary>
    public partial class ManagerUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid roomsTable;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Floor;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Floor_Copy;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Floor_Copy1;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid roomsEquipmentTable;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RoomInventory;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowRoomInventory;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid equipmenttTable;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEquipment;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditEquipment;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\ManagerUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteEquipment;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/managerui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManagerUI.xaml"
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
            this.roomsTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Floor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Floor_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Floor_Copy1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.roomsEquipmentTable = ((System.Windows.Controls.DataGrid)(target));
            
            #line 112 "..\..\..\ManagerUI.xaml"
            this.roomsEquipmentTable.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 127 "..\..\..\ManagerUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 128 "..\..\..\ManagerUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 129 "..\..\..\ManagerUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RoomInventory = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\ManagerUI.xaml"
            this.RoomInventory.Click += new System.Windows.RoutedEventHandler(this.RoomInventory_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ShowRoomInventory = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\ManagerUI.xaml"
            this.ShowRoomInventory.Click += new System.Windows.RoutedEventHandler(this.ShowRoomInventory_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.equipmenttTable = ((System.Windows.Controls.DataGrid)(target));
            
            #line 166 "..\..\..\ManagerUI.xaml"
            this.equipmenttTable.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 12:
            this.AddEquipment = ((System.Windows.Controls.Button)(target));
            
            #line 177 "..\..\..\ManagerUI.xaml"
            this.AddEquipment.Click += new System.Windows.RoutedEventHandler(this.AddEquipment_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.EditEquipment = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\ManagerUI.xaml"
            this.EditEquipment.Click += new System.Windows.RoutedEventHandler(this.EditEquipment_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.DeleteEquipment = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\..\ManagerUI.xaml"
            this.DeleteEquipment.Click += new System.Windows.RoutedEventHandler(this.DeleteEquipment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

