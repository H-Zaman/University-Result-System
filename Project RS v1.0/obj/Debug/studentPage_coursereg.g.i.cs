﻿#pragma checksum "..\..\studentPage_coursereg.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E73604018647865FDB51CD03DE46B61F"
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
    /// studentPage_coursereg
    /// </summary>
    public partial class studentPage_coursereg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_stuCourseReg;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registerCourse;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_show;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboYear;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\studentPage_coursereg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboSem;
        
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
            System.Uri resourceLocater = new System.Uri("/Project RS v1.0;component/studentpage_coursereg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\studentPage_coursereg.xaml"
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
            this.grid_stuCourseReg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\studentPage_coursereg.xaml"
            this.grid_stuCourseReg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grid_stuCourseReg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_registerCourse = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\studentPage_coursereg.xaml"
            this.btn_registerCourse.Click += new System.Windows.RoutedEventHandler(this.btn_registerCourse_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_show = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\studentPage_coursereg.xaml"
            this.btn_show.Click += new System.Windows.RoutedEventHandler(this.btn_show_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.comboYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.comboSem = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
