﻿#pragma checksum "..\..\adminPage_Marks.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6382C6FD276E959B37E97A6C26CD3C02"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_RS_v1._0;
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


namespace Project_RS_v1._0 {
    
    
    /// <summary>
    /// adminPage_Marks
    /// </summary>
    public partial class adminPage_Marks : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3_Copy;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboSelectSubj;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_teacher;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3_Copy1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelStu_id;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3_Copy3;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mark_text;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button show;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3_Copy2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\adminPage_Marks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelStu_subj;
        
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
            System.Uri resourceLocater = new System.Uri("/Project RS v1.0;component/adminpage_marks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\adminPage_Marks.xaml"
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
            this.label3_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.comboSelectSubj = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.grid_teacher = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\adminPage_Marks.xaml"
            this.grid_teacher.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grid_teacher_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label3_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.labelStu_id = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label3_Copy3 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.mark_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\adminPage_Marks.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.show = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\adminPage_Marks.xaml"
            this.show.Click += new System.Windows.RoutedEventHandler(this.show_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.label3_Copy2 = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.labelStu_subj = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

