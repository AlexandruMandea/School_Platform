﻿#pragma checksum "..\..\..\..\Views\TeacherWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07D01FA6FC72B5A8228D87BA3308A6DE2054668C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SchoolPlatform.ViewModels;
using SchoolPlatform.Views;
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


namespace SchoolPlatform.Views {
    
    
    /// <summary>
    /// TeacherWindow
    /// </summary>
    public partial class TeacherWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Views\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Absences;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Marks;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Average;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClassMasterBusiness;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Frame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SchoolPlatform;component/views/teacherwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\TeacherWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Absences = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\TeacherWindow.xaml"
            this.Absences.Click += new System.Windows.RoutedEventHandler(this.Absences_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Marks = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\TeacherWindow.xaml"
            this.Marks.Click += new System.Windows.RoutedEventHandler(this.Marks_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Average = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Views\TeacherWindow.xaml"
            this.Average.Click += new System.Windows.RoutedEventHandler(this.MakeAverage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ClassMasterBusiness = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Views\TeacherWindow.xaml"
            this.ClassMasterBusiness.Click += new System.Windows.RoutedEventHandler(this.ClassMasterBusiness_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Frame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

