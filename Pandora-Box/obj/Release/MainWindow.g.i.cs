﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F840D0D75DC2C16E5EAC5678D9BFCC74F7C158DB3CAD553A6AD25E62DB32DB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Pandora_Box;
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


namespace Pandora_Box {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button about;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.CircleProgressBar TemperatureInstrument;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userinfo;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CurrentTime;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CurrentTemperatureDisplay;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WarningLightState;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FanSwitchState;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StateTheHeater;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpperLimitTemperature;
        
        #line default
        #line hidden
        
        
        #line 285 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LowerLimitTemperature;
        
        #line default
        #line hidden
        
        
        #line 302 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TemperatureThresholdSettings;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetTemperatureThreshold;
        
        #line default
        #line hidden
        
        
        #line 343 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FanControlOpen;
        
        #line default
        #line hidden
        
        
        #line 349 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FanControlClearance;
        
        #line default
        #line hidden
        
        
        #line 369 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HeaterControlOpen;
        
        #line default
        #line hidden
        
        
        #line 375 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HeaterControlShut;
        
        #line default
        #line hidden
        
        
        #line 394 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SteeringGearRotationAngle;
        
        #line default
        #line hidden
        
        
        #line 404 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SteeringLeft;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SteeringGearRight;
        
        #line default
        #line hidden
        
        
        #line 421 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem History;
        
        #line default
        #line hidden
        
        
        #line 436 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart mychart;
        
        #line default
        #line hidden
        
        
        #line 440 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis myAxisX;
        
        #line default
        #line hidden
        
        
        #line 446 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis myAxisY;
        
        #line default
        #line hidden
        
        
        #line 460 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChartToSave;
        
        #line default
        #line hidden
        
        
        #line 466 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReadChart;
        
        #line default
        #line hidden
        
        
        #line 488 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Snackbar Snackbar;
        
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
            System.Uri resourceLocater = new System.Uri("/Pandora-Box;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 13 "..\..\MainWindow.xaml"
            ((Pandora_Box.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.about = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.about.Click += new System.Windows.RoutedEventHandler(this.about_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logout = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.logout.Click += new System.Windows.RoutedEventHandler(this.logout_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TemperatureInstrument = ((HandyControl.Controls.CircleProgressBar)(target));
            return;
            case 7:
            this.userinfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.CurrentTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.CurrentTemperatureDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.WarningLightState = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.FanSwitchState = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.StateTheHeater = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.UpperLimitTemperature = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.LowerLimitTemperature = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.TemperatureThresholdSettings = ((System.Windows.Controls.Button)(target));
            
            #line 303 "..\..\MainWindow.xaml"
            this.TemperatureThresholdSettings.Click += new System.Windows.RoutedEventHandler(this.TemperatureThresholdSettings_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.ResetTemperatureThreshold = ((System.Windows.Controls.Button)(target));
            
            #line 310 "..\..\MainWindow.xaml"
            this.ResetTemperatureThreshold.Click += new System.Windows.RoutedEventHandler(this.ResetTemperatureThreshold_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.FanControlOpen = ((System.Windows.Controls.Button)(target));
            
            #line 344 "..\..\MainWindow.xaml"
            this.FanControlOpen.Click += new System.Windows.RoutedEventHandler(this.FanControlOpen_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.FanControlClearance = ((System.Windows.Controls.Button)(target));
            
            #line 350 "..\..\MainWindow.xaml"
            this.FanControlClearance.Click += new System.Windows.RoutedEventHandler(this.FanControlClearance_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.HeaterControlOpen = ((System.Windows.Controls.Button)(target));
            
            #line 370 "..\..\MainWindow.xaml"
            this.HeaterControlOpen.Click += new System.Windows.RoutedEventHandler(this.HeaterControlOpen_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.HeaterControlShut = ((System.Windows.Controls.Button)(target));
            
            #line 376 "..\..\MainWindow.xaml"
            this.HeaterControlShut.Click += new System.Windows.RoutedEventHandler(this.HeaterControlShut_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.SteeringGearRotationAngle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 22:
            this.SteeringLeft = ((System.Windows.Controls.Button)(target));
            
            #line 405 "..\..\MainWindow.xaml"
            this.SteeringLeft.Click += new System.Windows.RoutedEventHandler(this.SteeringLeft_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.SteeringGearRight = ((System.Windows.Controls.Button)(target));
            
            #line 411 "..\..\MainWindow.xaml"
            this.SteeringGearRight.Click += new System.Windows.RoutedEventHandler(this.SteeringGearRight_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.History = ((System.Windows.Controls.TabItem)(target));
            return;
            case 25:
            this.mychart = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 26:
            this.myAxisX = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 27:
            this.myAxisY = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 28:
            this.ChartToSave = ((System.Windows.Controls.Button)(target));
            
            #line 461 "..\..\MainWindow.xaml"
            this.ChartToSave.Click += new System.Windows.RoutedEventHandler(this.ChartToSave_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.ReadChart = ((System.Windows.Controls.Button)(target));
            
            #line 467 "..\..\MainWindow.xaml"
            this.ReadChart.Click += new System.Windows.RoutedEventHandler(this.ReadChart_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.Snackbar = ((MaterialDesignThemes.Wpf.Snackbar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
