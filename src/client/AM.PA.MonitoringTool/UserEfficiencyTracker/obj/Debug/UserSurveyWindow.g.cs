﻿#pragma checksum "..\..\UserSurveyWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1FC76104010E0B999CA1529F18E78A0F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UserEfficiencyTracker.Helpers;


namespace UserEfficiencyTracker {
    
    
    /// <summary>
    /// UserSurveyWindow
    /// </summary>
    public partial class UserSurveyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PreviousSurveyDateTime;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ProductivitySlider;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PreviousInsertsStackPanel;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prev1TextBlock;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prev2TextBlock;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prev3TextBlock;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prev4TextBlock;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prev5TextBlock;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Prev6TextBlock;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl UserTaskList;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\UserSurveyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider EmotionsSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/UserEfficiencyTracker;component/usersurveywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserSurveyWindow.xaml"
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
            
            #line 10 "..\..\UserSurveyWindow.xaml"
            ((UserEfficiencyTracker.UserSurveyWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.UserSurveyWindow_OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PreviousSurveyDateTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ProductivitySlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            
            #line 109 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 110 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 111 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 112 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 113 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 114 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.PreviousInsertsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.Prev1TextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 121 "..\..\UserSurveyWindow.xaml"
            this.Prev1TextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Prev2TextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 122 "..\..\UserSurveyWindow.xaml"
            this.Prev2TextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Prev3TextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 123 "..\..\UserSurveyWindow.xaml"
            this.Prev3TextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Prev4TextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 124 "..\..\UserSurveyWindow.xaml"
            this.Prev4TextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Prev5TextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 125 "..\..\UserSurveyWindow.xaml"
            this.Prev5TextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Prev6TextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 126 "..\..\UserSurveyWindow.xaml"
            this.Prev6TextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PredefinedText_Clicked);
            
            #line default
            #line hidden
            return;
            case 17:
            this.UserTaskList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 21:
            this.EmotionsSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 22:
            
            #line 212 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OKButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 18:
            
            #line 145 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TaskDescription_TextChanged);
            
            #line default
            #line hidden
            break;
            case 19:
            
            #line 147 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.ListBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbSuggestion_SuggestionChanged);
            
            #line default
            #line hidden
            break;
            case 20:
            
            #line 150 "..\..\UserSurveyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveTaskEntry_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

