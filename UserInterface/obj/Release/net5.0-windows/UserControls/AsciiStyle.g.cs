﻿#pragma checksum "..\..\..\..\UserControls\AsciiStyle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03B6FC37AD2666DD0D4A824F2BCB7C17CA7EB9B0"
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
using UserInterface;


namespace UserInterface.UserControls {
    
    
    /// <summary>
    /// AsciiStyle
    /// </summary>
    public partial class AsciiStyle : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UserInterface.UserControls.AsciiStyle AsciiStyleUserControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCharacterSlot;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveCharacterSlot;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdrBlackToWhiteGradient;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop grdntStpLeft;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop grdntStpRight;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReverseGradient;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\UserControls\AsciiStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdCharactersPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/usercontrols/asciistyle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\AsciiStyle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AsciiStyleUserControl = ((UserInterface.UserControls.AsciiStyle)(target));
            return;
            case 2:
            this.btnAddCharacterSlot = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\UserControls\AsciiStyle.xaml"
            this.btnAddCharacterSlot.Click += new System.Windows.RoutedEventHandler(this.MenuItem_AddCharacter_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnRemoveCharacterSlot = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\UserControls\AsciiStyle.xaml"
            this.btnRemoveCharacterSlot.Click += new System.Windows.RoutedEventHandler(this.MenuItem_RemoveCharacter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.brdrBlackToWhiteGradient = ((System.Windows.Controls.Border)(target));
            
            #line 26 "..\..\..\..\UserControls\AsciiStyle.xaml"
            this.brdrBlackToWhiteGradient.MouseEnter += new System.Windows.Input.MouseEventHandler(this.borderBlackToWhiteGradient_MouseEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\UserControls\AsciiStyle.xaml"
            this.brdrBlackToWhiteGradient.MouseLeave += new System.Windows.Input.MouseEventHandler(this.borderBlackToWhiteGradient_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grdntStpLeft = ((System.Windows.Media.GradientStop)(target));
            return;
            case 6:
            this.grdntStpRight = ((System.Windows.Media.GradientStop)(target));
            return;
            case 7:
            this.btnReverseGradient = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\UserControls\AsciiStyle.xaml"
            this.btnReverseGradient.Click += new System.Windows.RoutedEventHandler(this.btnReverseGradient_Click);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\UserControls\AsciiStyle.xaml"
            this.btnReverseGradient.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnReverseGradient_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grdCharactersPanel = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

