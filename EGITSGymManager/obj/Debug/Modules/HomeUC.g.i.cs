﻿#pragma checksum "..\..\..\Modules\HomeUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29903169AE7956281CE959564A950BD9"
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


namespace EGITSGymManager.Modules {
    
    
    /// <summary>
    /// HomeUC
    /// </summary>
    public partial class HomeUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DashboardBtn;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MembersBtn;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddContractBtn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NotificationBtn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmployeesBtn;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReportsBtn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PackagesBtn;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TitlesBtn;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Modules\HomeUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/EGITSGymManager;component/modules/homeuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Modules\HomeUC.xaml"
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
            this.MinimizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Modules\HomeUC.xaml"
            this.MinimizeBtn.Click += new System.Windows.RoutedEventHandler(this.LogoutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DashboardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Modules\HomeUC.xaml"
            this.DashboardBtn.Click += new System.Windows.RoutedEventHandler(this.DashboardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MembersBtn = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Modules\HomeUC.xaml"
            this.MembersBtn.Click += new System.Windows.RoutedEventHandler(this.MembersBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddContractBtn = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Modules\HomeUC.xaml"
            this.AddContractBtn.Click += new System.Windows.RoutedEventHandler(this.AddContractBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NotificationBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Modules\HomeUC.xaml"
            this.NotificationBtn.Click += new System.Windows.RoutedEventHandler(this.NotificationBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EmployeesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Modules\HomeUC.xaml"
            this.EmployeesBtn.Click += new System.Windows.RoutedEventHandler(this.EmployeesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReportsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Modules\HomeUC.xaml"
            this.ReportsBtn.Click += new System.Windows.RoutedEventHandler(this.ReportsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PackagesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Modules\HomeUC.xaml"
            this.PackagesBtn.Click += new System.Windows.RoutedEventHandler(this.PackagesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TitlesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Modules\HomeUC.xaml"
            this.TitlesBtn.Click += new System.Windows.RoutedEventHandler(this.TitlesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
